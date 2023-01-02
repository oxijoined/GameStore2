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
    /// Логика взаимодействия для GamesFrame.xaml
    /// </summary>
    public partial class GamesFrame : Page
    {
        public GamesFrame()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            var rectangle = sender as Rectangle;
            rectangle.Fill.Opacity = 0.8;
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            var rectangle = sender as Rectangle;
            rectangle.Fill.Opacity = 1;
        }
    }
}
