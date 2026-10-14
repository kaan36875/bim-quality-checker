using System.Windows;
using BIMQualityChecker.RevitAdapter.ViewModels;

namespace BIMQualityChecker.RevitAdapter.Views
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow(SettingsViewModel viewModel)
        {
            InitializeComponent();
            Icon = RibbonIcons.CreateCheckIcon(32);
            DataContext = viewModel;
            viewModel.CloseRequested += Close;
        }
    }
}
