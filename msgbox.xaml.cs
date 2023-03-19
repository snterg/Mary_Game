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
    /// Логика взаимодействия для msgbox.xaml
    /// </summary>
    public partial class msgbox : Window
    {
        string showt;
        public msgbox()
        {
            InitializeComponent();
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        public void get(string s)
        {
           
            text.Text = s;
        }
    }
}
