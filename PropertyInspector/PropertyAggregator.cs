using Autodesk.Navisworks.Api;
using System.Collections.Generic;

namespace PropertyInspector
{
    public static class PropertyAggregator
    {
        public static void ScanModel(bool useSelection = false)
        {
            // TODO: Implement property aggregation logic.
            Document doc = Application.ActiveDocument;
            ModelItemCollection items = useSelection ?
                doc.CurrentSelection.SelectedItems :
                doc.Models.RootItems;

            // Placeholder loops for compilation
            foreach (ModelItem item in items)
            {
                foreach (PropertyCategory category in item.PropertyCategories)
                {
                    foreach (DataProperty property in category.Properties)
                    {
                        // Collect unique properties and values
                    }
                }
            }
        }
    }
}
