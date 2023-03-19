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
    /// Логика взаимодействия для test_view.xaml
    /// </summary>
    public partial class test_view : Window
    {
        msgbox s;
        public test_view()
        {
            InitializeComponent();
            statics_class.create = true;
            if (statics_class.competition == false)
                start_game.Visibility = Visibility.Visible;
            else
            {
                start_game.Visibility = Visibility.Hidden;
                end_game.Visibility = Visibility.Visible;
            }
            s = new msgbox();
        }

        private void slider_count_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_value.Text =Convert.ToInt16(slider_count.Value).ToString();
        }

        private void start_game_Click(object sender, RoutedEventArgs e)
        {
            statics_class.cout_figure = Convert.ToInt16(slider_value.Text);
            statics_class.competition = true;
            statics_class.create = false;
            this.DialogResult = true;
            this.Close();
        }

        private void end_game_Click(object sender, RoutedEventArgs e)
        {
            statics_class.competition = false;
            statics_class.create = false;
            this.DialogResult = true;
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            statics_class.create = false;
        }

        private void color_check_Checked(object sender, RoutedEventArgs e)
        {
            if(color_check.IsChecked==true)
            statics_class.check_color = true;
            else
                statics_class.check_color = false;
        }

        private void competition_check_Checked(object sender, RoutedEventArgs e)
        {
            if (competition_check.IsChecked == true)
                statics_class.check_competition = true;
            else
                statics_class.check_competition = false;
        }
    }
}
