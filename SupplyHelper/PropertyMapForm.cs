using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyHelper
{
    public partial class PropertyMapForm : System.Windows.Forms.Form
    {
        private readonly Document document;
        private readonly Element element;
        public PropertyMapForm(List<(string, string)> semPropValues, Document document, Element element)
        {
            InitializeComponent();
            this.document = document;
            this.element = element;
            foreach (var item in semPropValues)
            {
                semPropGrid.Rows.Add(item.Item1, item.Item2);
            }
            var sharedParamFile = document.Application.OpenSharedParameterFile();
            MessageBox.Show(sharedParamFile.Groups.Count().ToString());
            sharedObjectNames.DataSource = sharedParamFile.Groups.Select(c => c.Name).ToList();
            var res = HttpRequester.GetData("https://localhost:7041/Pipe/ReguestInfo").ConfigureAwait(false).GetAwaiter().GetResult();
            var requestInfo = JsonSerializer.Deserialize<RequestInfoDto>(res);
            neededPropGrid.Rows.Add("Категория", requestInfo.CategoryNames);
            neededPropGrid.Rows.Add("Гост", requestInfo.GostNames);
            neededPropGrid.Rows.Add("Наименование", requestInfo.PipeName);
            neededPropGrid.Rows.Add("SDR", requestInfo.SDR);
            neededPropGrid.Rows.Add("Толщина", requestInfo.Thickness);
            neededPropGrid.Rows.Add("Диаметр", requestInfo.Diametr);
            ChangeToComboBox(neededPropGrid, 0, requestInfo.CategoryNames);
            ChangeToComboBox(neededPropGrid, 1, requestInfo.GostNames);
        }

        private void ChangeToComboBox(DataGridView dataGridView, int rowIndex, List<string> items)
        {
            // Проверяем, чтобы ячейка была в нужной строке
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                // Создаём новый DataGridViewComboBoxCell для этой строки
                DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();

                // Добавляем значения в ComboBox
                comboCell.DataSource = items;
                comboCell.Value = items.FirstOrDefault();
                // Заменяем ячейку в нужной строке на ComboBox
                dataGridView.Rows[rowIndex].Cells["dataGridViewTextBoxColumn2"] = comboCell;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private List<(int, string)> choosedPropData = new List<(int, string)>();

        private void button1_Click(object sender, EventArgs e)
        {

            var selectedProps = semPropGrid.SelectedRows;

            for (int i = 0; i < selectedProps.Count; i++)
            {
                choosenPropsList.Items.Add(selectedProps[i].Cells["Name"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choosenPropsList.Items.RemoveAt(choosenPropsList.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = choosenPropsList.SelectedIndex;
            if (index < choosenPropsList.Items.Count - 1 && index >= 0) // Проверяем, что элемент не последний
            {
                object item = choosenPropsList.Items[index];
                choosenPropsList.Items.RemoveAt(index);
                choosenPropsList.Items.Insert(index + 1, item);
                choosenPropsList.SelectedIndex = index + 1; // Сохраняем выделение
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = choosenPropsList.SelectedIndex;
            if (index > 0) // Проверяем, что элемент не первый
            {
                object item = choosenPropsList.Items[index];
                choosenPropsList.Items.RemoveAt(index);
                choosenPropsList.Items.Insert(index - 1, item);
                choosenPropsList.SelectedIndex = index - 1; // Сохраняем выделение
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            var content = new NeededPipeRequestData()
            {
                CategoryName = neededPropGrid.Rows[0].Cells[1].Value.ToString(),
                GostName = neededPropGrid.Rows[1].Cells[1].Value.ToString(),
                PipeName = neededPropGrid.Rows[2].Cells[1].Value.ToString(),
                SDR = Convert.ToDouble(neededPropGrid.Rows[3].Cells[1].Value),
                Thickness = Convert.ToDouble(neededPropGrid.Rows[4].Cells[1].Value),
                Diametr = Convert.ToDouble(neededPropGrid.Rows[5].Cells[1].Value),
            };

            var json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var httpRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:7041/Pipe/GetApplicablePipes"),
                Content = content
            };
            var d = HttpRequester.SendRequest(httpRequest).ConfigureAwait(false).GetAwaiter().GetResult();

            MessageBox.Show(d);
        }

        private void addNewPropButton_Click(object sender, EventArgs e)
        {
            bool isOnlySemName = false;
            if (string.IsNullOrEmpty(newPropNameTextBox.Text))
            {
                isOnlySemName = true;
            }

            using (Transaction tx = new Transaction(this.document, "Добавить параметр"))
            {
                tx.Start();

                // Добавляем параметр к выбранному элементу
                AddSharedParameter(document, element, sharedObjectNames.Text, newPropNameTextBox.Text, newPropValueTextBox.Text);
                
                tx.Commit();
            }

        }

        private void SetPatameterWithValue(string paramName, string value)
        {
            using (Transaction trans = new Transaction(document, "Добавить параметр"))
            {
                trans.Start();

                // Проверим, существует ли уже общий параметр с данным именем
                DefinitionFile sharedParamFile = document.Application.OpenSharedParameterFile();
                if (sharedParamFile == null)
                {
                    MessageBox.Show("Ошибка", "Не найден файл общих параметров.");
                }

                // Определение параметра
                ExternalDefinition externalDef = GetExternalDefinition(sharedParamFile, sharedObjectNames.SelectedText);
                if (externalDef == null)
                {
                    TaskDialog.Show("Ошибка", "Не удалось найти параметр в файле общих параметров.");
                }

                // Добавляем параметр ко всем элементам
                AddSharedParameterToAllElements(document, externalDef, paramName);

                trans.Commit();
            }
        }


        // Функция для добавления нового параметра

        private void AddSharedParameter(Document doc, Element element, string groupName, string paramName, string paramValue)
        {
            // Получаем файл общих данных
            DefinitionFile definitionFile = doc.Application.OpenSharedParameterFile();

            if (definitionFile == null)
            {
                TaskDialog.Show("Ошибка", "Не найден файл общих данных.");
                return;
            }

            // Проверяем, существует ли параметр с таким именем
            DefinitionGroup definitionGroup = definitionFile.Groups.FirstOrDefault(g => g.Name == groupName);
            MessageBox.Show(groupName);
            if (definitionGroup == null)
            {
                definitionGroup = definitionFile.Groups.Create(groupName);
            }

            // Проверяем, есть ли уже параметр с таким именем
            ExternalDefinition externalDefinition = definitionGroup.Definitions.Cast<ExternalDefinition>()
                .FirstOrDefault(def => def.Name == paramName);

            if (externalDefinition == null)
            {
                // Создаем новый внешний параметр
                ExternalDefinitionCreationOptions options = new ExternalDefinitionCreationOptions(paramName, ParameterType.Text);
                externalDefinition = definitionGroup.Definitions.Create(options) as ExternalDefinition;
            }

            // Привязываем параметр к элементу
            BindingMap bindingMap = doc.ParameterBindings;
            Category category = element.Category;

            CategorySet categorySet = doc.Application.Create.NewCategorySet();
            categorySet.Insert(category);

            // Создаем привязку
            if (externalDefinition != null)
            {
                InstanceBinding binding = new InstanceBinding(categorySet);
                bindingMap.Insert(externalDefinition, binding);

                // Устанавливаем значение параметра
                Parameter parameter = element.LookupParameter(paramName);
                if (parameter != null)
                {
                    parameter.Set(paramValue);
                }
            }
        }










        private ExternalDefinition GetExternalDefinition(DefinitionFile sharedParamFile, string sharedParamName)
        {
            foreach (DefinitionGroup defGroup in sharedParamFile.Groups)
            {
               
                    if (defGroup.Name == sharedParamName)
                    {
                       // return def as ExternalDefinition;
                    }
                
            }

            return null;
        }

        private void AddSharedParameterToAllElements(Document doc, ExternalDefinition externalDef, string paramValue)
        {
            // Создаем CategorySet для добавления параметра ко всем категориям
            CategorySet categories = doc.Application.Create.NewCategorySet();
            categories.Insert(element.Category); // Пример категории, можно добавить все

            // Добавляем параметр в проект
            AddSharedParameterToProject(doc, externalDef, categories);

            // Перебираем все элементы и добавляем параметр с заданным значением
                Parameter param = element.LookupParameter(externalDef.Name);
                if (param != null)
                {
                    // Устанавливаем значение параметра
                    param.Set(paramValue);
                }
        }

        private void AddSharedParameterToProject(Document doc, ExternalDefinition externalDef, CategorySet categories)
        {
            BindingMap bindings = doc.ParameterBindings;
            Autodesk.Revit.DB.Binding binding = doc.Application.Create.NewInstanceBinding(categories);
            bindings.Insert(externalDef, binding, BuiltInParameterGroup.PG_TEXT);
        }

        private ExternalDefinition CreateNewParameter(Document doc, string paramName)
        {
            // Открываем файл общих параметров
            DefinitionFile sharedParameterFile = doc.Application.OpenSharedParameterFile();
            if (sharedParameterFile == null)
            {
                MessageBox.Show("Ошибка", "Не найден файл общих параметров.");
                return null;
            }

            // Определяем группу и создаем новый параметр
            DefinitionGroup defGroup = sharedParameterFile.Groups.get_Item("Имя_группы");
            if (defGroup == null)
            {
                MessageBox.Show("Ошибка", "Не найдена указанная группа для параметра.");
                return null;
            }

            ExternalDefinition externalDef = defGroup.Definitions.Create(new ExternalDefinitionCreationOptions(paramName, ParameterType.Text)) as ExternalDefinition;
            return externalDef;
        }
    }
}
