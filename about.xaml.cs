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
using System.Windows.Shapes;

namespace Mary_Game
{
    /// <summary>
    /// Логика взаимодействия для about.xaml
    /// </summary>
    public partial class about : Window
    {
        public about()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void PackIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            butexit.Foreground = Brushes.Red;
        }

        private void butexit_MouseLeave(object sender, MouseEventArgs e)
        {
            butexit.Foreground = Brushes.DarkRed;
        }
    }
}
