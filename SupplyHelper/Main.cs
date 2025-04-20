using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
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
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public Element element { get; set; }
        public Document document;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Позволяем пользователю выбрать элемент
                //Reference pickedRef = _uiDoc.Selection.PickObject(ObjectType.Element, "Выберите элемент");
                //if (pickedRef == null) return;

                //Element element = _uiDoc.Document.GetElement(pickedRef.ElementId);

                // Получаем свойства элемента
                StringBuilder properties = new StringBuilder();
                properties.AppendLine($"Имя элемента: {element.Name}");
                properties.AppendLine($"ID: {element.Id.IntegerValue}");
                List<(string, string)> propValues = new List<(string, string)>() { };
                foreach (Parameter param in element.Parameters)
                {
                    var value = param.AsString() ?? param.AsValueString() ?? param.AsInteger().ToString() ?? string.Empty;
                    propValues.Add((param.Definition.Name, value));
                }
                
                PropertyMapForm propertyMapForm = new PropertyMapForm(propValues, document, element);
                propertyMapForm.ShowDialog();
            }
            catch (Autodesk.Revit.Exceptions.OperationCanceledException)
            {
                MessageBox.Show("Выбор отменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message} {ex.InnerException} {ex.StackTrace}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //// Получаем активный документ
            //UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            //Document doc = uiDoc.Document;

            //Reference pickedRef = uiDoc.Selection.PickObject(ObjectType.Element, "Выберите элемент");
            //if (pickedRef == null)
            //{
            //    TaskDialog.Show("Ошибка", "Выбор отменен.");
            //}

            //// Получаем элемент
            //Element element = doc.GetElement(pickedRef.ElementId);

            //// Создаем строку для отображения свойств
            //StringBuilder properties = new StringBuilder();
            //properties.AppendLine($"Свойства элемента: {element.Name}");

            //// Получаем все параметры элемента
            //foreach (Parameter param in element.Parameters)
            //{
            //    if (param.HasValue)
            //    {
            //        string paramName = param.Definition.Name;
            //        string paramValue = param.AsString() ?? param.AsValueString() ?? param.AsInteger().ToString();
            //        properties.AppendLine($"{paramName}: {paramValue}");
            //    }
            //}

            //// Создаем окно для отображения свойств
            //MessageBox.Show(properties.ToString(), "Свойства элемента", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitConnectForm initConnectForm = new InitConnectForm();
            initConnectForm.ShowDialog();
        }
    }
}
