using System.Windows;
using BIMQualityChecker.RevitAdapter.ViewModels;

namespace BIMQualityChecker.RevitAdapter.Views
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            viewModel.CloseRequested += Close;
        }
    }
}
