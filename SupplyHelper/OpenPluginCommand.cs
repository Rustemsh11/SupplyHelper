using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace SupplyHelper
{
    [Autodesk.Revit.Attributes.TransactionAttribute(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class OpenPluginCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            Reference pickedRef = uiDoc.Selection.PickObject(ObjectType.Element, "Выберите элемент");
            if (pickedRef == null)
            {
                TaskDialog.Show("Ошибка", "Выбор отменен.");
            }

            // Получаем элемент
            Element element = doc.GetElement(pickedRef.ElementId);
            Main window = new Main();
            window.element = element;
            window.document = doc;
            window.ShowDialog();

            return Result.Succeeded;

        }
    }
}
