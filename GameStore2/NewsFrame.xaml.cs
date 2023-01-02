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

namespace GameStore2
{
    /// <summary>
    /// Логика взаимодействия для NewsFrame.xaml
    /// </summary>
    public partial class NewsFrame : Page
    {
        public NewsFrame()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            var rectangle = sender as Grid;
            rectangle.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#404040");
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            var rectangle = sender as Grid;
            rectangle.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#2d2d2d");
        }

    }
}
