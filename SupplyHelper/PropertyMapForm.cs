using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            StringBuilder props = new StringBuilder();
            foreach (var item in choosenPropsList.Items)
            {
                props.AppendLine(item.ToString());
            }
            MessageBox.Show(props.ToString(), "Свойства элемента", MessageBoxButtons.OK);
        }

        private void addNewPropButton_Click(object sender, EventArgs e)
        {
            bool isOnlySemName = false;
            if (string.IsNullOrEmpty(newPropNameTextBox.Text))
            {
                isOnlySemName = true;
            }

            SetPatameterWithValue(newPropNameTextBox.Text, newPropValueTextBox.Text);
        }

        private void SetPatameterWithValue(string paramName, string value)
        {
            using (Transaction transaction = new Transaction(document, "Добавить новое свойство"))
            {
                transaction.Start();
                Parameter existingParam = element.LookupParameter(paramName);

                if (existingParam == null)
                {
                    FamilyManager familyManager = document.FamilyManager;

                    CategorySet categories = new CategorySet();
                    categories.Insert(element.Category);

                    ExternalDefinition externalDefinition = CreateNewParameter(document, paramName);

                    if(externalDefinition != null)
                    {
                        var paramId = element.GetTypeId();
                        familyManager.AddParameter(externalDefinition, BuiltInParameterGroup.PG_TEXT, false);
                        element.LookupParameter(paramName).Set(value);
                    }
                }

                transaction.Commit();
            }
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
