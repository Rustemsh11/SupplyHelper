using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyHelper
{
    [Autodesk.Revit.Attributes.TransactionAttribute(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class GetElementPropertiesCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Получаем активный документ
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;
            Reference pickedRef = uiDoc.Selection.PickObject(ObjectType.Element, "Выберите элемент");
            if (pickedRef == null)
            {
                TaskDialog.Show("Ошибка", "Выбор отменен.");
                return Result.Failed;
            }

            // Получаем элемент
            Element element = doc.GetElement(pickedRef.ElementId);

            // Создаем строку для отображения свойств
            StringBuilder properties = new StringBuilder();
            properties.AppendLine($"Свойства элемента: {element.Name}");

            // Получаем все параметры элемента
            foreach (Parameter param in element.Parameters)
            {
                if (param.HasValue)
                {
                    string paramName = param.Definition.Name;
                    string paramValue = param.AsString() ?? param.AsValueString() ?? param.AsInteger().ToString();
                    properties.AppendLine($"{paramName}: {paramValue}");
                }
            }

            // Создаем окно для отображения свойств
            MessageBox.Show(properties.ToString(), "Свойства элемента", MessageBoxButtons.OK);

            return Result.Succeeded;
        }
    }
}
