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
    /// Логика взаимодействия для Picture_test_view.xaml
    /// </summary>
    public partial class Picture_test_view : Window
    {
        int selection = -2;
        msgbox s;
        public Picture_test_view()
        {
            InitializeComponent();
            statics_class.create_picttest = true;
            if (statics_class.competition_pict == false)
                start_game.Visibility = Visibility.Visible;
            else
            {
                start_game.Visibility = Visibility.Hidden;
                end_game.Visibility = Visibility.Visible;
            }
             s= new msgbox();
        }

        private void start_game_Click(object sender, RoutedEventArgs e)
        {
            statics_class.competition_pict = true;
            statics_class.create_picttest = false;
            if (selection == 1||selection==2)
            {

                s.get("Данные уровни находятся в разработке");
                s.ShowDialog();
                //MessageBox.Show("Данные уровни находятся в разработке");
                return;
            }
            if (selection == -2)
            {
                s.get("Вы не выбрали уровень");
                s.ShowDialog();
                //MessageBox.Show("Вы не выбрали уровень");
                return;
            }
            statics_class.picture_level = selection;
            this.DialogResult = true;
            this.Close();
        }

        private void end_game_Click(object sender, RoutedEventArgs e)
        {
            statics_class.competition_pict = false;
            statics_class.create_picttest = false;
            this.DialogResult = true;
            this.Close();
        }

        private void comb_level_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selection = comb_level.SelectedIndex;
        }
    }
}
