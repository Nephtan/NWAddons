using System.Windows;
using System.Windows.Controls;

namespace PropertyInspector
{
    public partial class PropertyInspectorControl : UserControl
    {
        public PropertyInspectorControl()
        {
            InitializeComponent();
            ScanButton.Click += ScanButton_Click;
        }

        private void ScanButton_Click(object sender, RoutedEventArgs e)
        {
            PropertyAggregator.ScanModel();
        }
    }
}
