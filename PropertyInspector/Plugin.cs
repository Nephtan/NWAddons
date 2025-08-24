using Autodesk.Navisworks.Api.Plugins;
using System.Windows;
using System.Windows.Controls;

namespace PropertyInspector
{
    [Plugin("PropertyInspector", "NWAD", DisplayName = "Property Inspector", ToolTip = "Inspect and colorize model properties"),
     DockPanePlugin(400, 300, AutoVisible = true)]
    public class Plugin : DockPanePlugin
    {
        private PropertyInspectorControl? _control;

        public override Control CreateControlPane()
        {
            _control = new PropertyInspectorControl();
            return _control;
        }

        public override void DestroyControlPane(Control pane)
        {
            _control = null;
            base.DestroyControlPane(pane);
        }
    }
}
