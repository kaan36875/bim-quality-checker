using System.Windows;

namespace BIMQualityChecker.RevitAdapter.Views
{
    public partial class ProgressWindow : Window
    {
        public ProgressWindow()
        {
            InitializeComponent();
        }

        public void UpdateStatus(string status, string detail = null)
        {
            StatusText.Text = status;
            if (detail != null)
                DetailText.Text = detail;
        }
    }
}
