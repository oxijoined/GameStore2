using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui.Appearance;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Interfaces;
using Wpf.Ui.Controls.Navigation;
using Wpf.Ui.Mvvm.Contracts;
using Wpf.Ui.Mvvm.Services;

namespace GameStore2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Wpf.Ui.Controls.UiWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new DashboardFrame();
            Wpf.Ui.Appearance.Theme.Apply(
            Wpf.Ui.Appearance.ThemeType.Dark,
            Wpf.Ui.Appearance.BackgroundType.Mica,
            true
            );

        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new DashboardFrame();
            Dashboard.IsActive = true;
            Games.IsActive = false;
            News.IsActive = false;
            Profile.IsActive = false;
            Settings.IsActive = false;
        }

        private void Games_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new GamesFrame();
            Dashboard.IsActive = false;
            Games.IsActive = true;
            News.IsActive = false;
            Profile.IsActive = false;
            Settings.IsActive = false;
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new NewsFrame();
            Dashboard.IsActive = false;
            Games.IsActive = false;
            News.IsActive = true;
            Profile.IsActive = false;
            Settings.IsActive = false;
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ProfileFrame();
            Dashboard.IsActive = false;
            Games.IsActive = false;
            News.IsActive = false;
            Profile.IsActive = true;
            Settings.IsActive = false;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SettingsFrame();
            Dashboard.IsActive = false;
            Games.IsActive = false;
            News.IsActive = false;
            Profile.IsActive = false;
            Settings.IsActive = true;
        }
    }
}
