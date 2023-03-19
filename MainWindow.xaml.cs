using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
using MaterialDesignThemes.Wpf;
using MaterialDesignColors.ColorManipulation;
using System.Media;
using System.IO;
using System.Threading;

namespace Mary_Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SolidColorBrush brush = new SolidColorBrush();
        bool cr = false, sq = false, rb = false, st = false, ar = false, elp = false, tr = false, pol = false, kv = false;
        PackIcon p = new PackIcon();
        int lang=1;
        int kc = 0,kf=0,uc=0,compcount=0,comperrcouunt=0;
        Random rnd = new Random();
        MediaPlayer sp = new MediaPlayer();
        string dir = Directory.GetCurrentDirectory();
        string s = "";
        bool f1 = false, f2 = false, f3 = false;
        msgbox msg;
        public MainWindow()
        {
            InitializeComponent();
            #region
            // SplashScreen splashScreen = new SplashScreen("Pict\\splash.png");
            //  splashScreen.Show(true);
            #endregion
            brush.Color= Colors.LightGray;
            statics_class.competition = false;
            msg = new msgbox(); 

           
           
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            picturepanel.Children.Clear();
        }
        private void BLR_MouseDown(object sender, MouseButtonEventArgs e)
        {

            BLR_BR.BorderThickness = new Thickness(5, 5, 5, 5);
            BLR_BR.BorderBrush = Brushes.Green;
            RUS_BR.BorderThickness = new Thickness(0, 0, 0, 0);
            RUS_BR.BorderBrush = Brushes.Transparent;
            USA_BR.BorderThickness = new Thickness(0, 0, 0, 0);
            USA_BR.BorderBrush = Brushes.Transparent;
            lang = 0;

        }

        private void RUS_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BLR_BR.BorderThickness = new Thickness(0, 0, 0, 0);
            BLR_BR.BorderBrush = Brushes.Transparent;
            RUS_BR.BorderThickness = new Thickness(5, 5, 5, 5);
            RUS_BR.BorderBrush = Brushes.Green;
            USA_BR.BorderThickness = new Thickness(0, 0, 0, 0);
            USA_BR.BorderBrush = Brushes.Transparent;
            lang = 1;
        }

        private void US_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BLR_BR.BorderThickness = new Thickness(0, 0, 0, 0);
            BLR_BR.BorderBrush = Brushes.Transparent;
            RUS_BR.BorderThickness = new Thickness(0, 0, 0, 0);
            RUS_BR.BorderBrush = Brushes.Transparent;
            USA_BR.BorderThickness = new Thickness(5, 5, 5, 5);
            USA_BR.BorderBrush = Brushes.Green;
            lang = 2;
        }
        void generate(int choose)
        {
            if (choose == kf)
            {
                msg.get("Верно");
                msg.ShowDialog();
                //MessageBox.Show("Верно");
                if(statics_class.check_color==true)
                choose_color();
                kf = rnd.Next(1, statics_class.cout_figure);
                choose_figure(kf);
                if (statics_class.check_competition == true)
                {
                    compcount++;
                    compcont.Text = "Верно:" + compcount + " Не верно:" + comperrcouunt;
                }
            }
            else
            {
                msg.get("Попробуй еще раз");
                msg.ShowDialog();
               // MessageBox.Show("Попоробуй еще раз");
                if (statics_class.check_competition == true)
                {
                    comperrcouunt++;
                    compcont.Text = "Верно:" + compcount + " Не верно:" + comperrcouunt;
                }
                return;
            }
        }
 private void drawcircle(SolidColorBrush clr)
        {

            picturepanel.Children.Clear();
            #region
            //Ellipse el = new Ellipse();
            //el.Width = picturepanel.ActualWidth;
            //el.Height = picturepanel.ActualWidth;
            //el.Margin = new Thickness(0, el.Height / picturepanel.ActualWidth, 0, 0);
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill = clr;
            //el.Stroke = Brushes.Gray;
            //el.StrokeThickness = 3;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Circle;
            p.Width = picturepanel.ActualWidth;
            p.Height= picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            cr = true;
            sq = rb = st = ar = elp = tr = pol =kv = false;
            if(statics_class.competition_pict==true)
            {
                f1 = true;
                if (f1 = true && f2 == false && f3 == false)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r4.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if(f1 = true && f2 == true && f3 == false)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r5.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f1 = true && f2 == false && f3 == true)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r8.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f1 = true && f2 == true && f3 == true)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r9.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                    msg.get("Ты все завершил! Молодец!");
                    msg.ShowDialog();

                }
            }
            if (lang == 0)
            {   if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
            else
                Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\круг.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\круг.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\US\circle.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }
        private void circle_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 1;
                generate(uc);
            }
            else
            {
              
                //brush = Brushes.MintCream;
                drawcircle(brush);
            }
            #region//circle_button.Background = Brushes.LightBlue;
            #endregion

        }


        private void drawsquare(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region
            //Rectangle el = new Rectangle();
            //el.Width = picturepanel.ActualWidth;
            //el.Height = picturepanel.ActualHeight / 2;
            //el.Fill = clr;
            //el.Margin = new Thickness(0, picturepanel.ActualHeight / 4, 0, 0);
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill = clr;
            //el.Stroke = Brushes.Gray;
            //el.StrokeThickness = 3;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Rectangle;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            sq = true;
            cr = rb = st = ar = elp = tr = pol = kv = false;
            if (statics_class.competition_pict == true)
            {
                f3 = true;
                if (f3 = true && f2 == false && f1 == false)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r3.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f3 = true && f2 == true && f1 == false)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r7.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f3 = true && f2 == false && f1 == true)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r8.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f3 = true && f2 == true && f1 == true)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r9.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                    msg.get("Ты все завершил! Молодец!");
                    msg.ShowDialog();
                }
            }
            if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\прастакутник.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\прямоугольник.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\rectangle.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }
        
            private void square_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 2;
                generate(uc);
            }
            else
            {
                //brush = Brushes.MintCream;
                drawsquare(brush);
            }
        }
        private void triangle_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 7;
                generate(uc);
            }
            else
            {
               // brush = Brushes.MintCream;
                drawtriangle(brush);
            }
        }
        private void drawtriangle(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region
            //Polygon el = new Polygon();
            //System.Windows.Point Point1 = new System.Windows.Point(picturepanel.ActualWidth / 2, 0);
            //System.Windows.Point Point2 = new System.Windows.Point(picturepanel.ActualWidth, picturepanel.ActualHeight / 2);
            //System.Windows.Point Point3 = new System.Windows.Point(0, picturepanel.ActualHeight / 2);
            //PointCollection myPointCollection = new PointCollection();
            //myPointCollection.Add(Point1);
            //myPointCollection.Add(Point2);
            //myPointCollection.Add(Point3);
            //el.Points = myPointCollection;
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill = clr;
            //el.Stroke = Brushes.Gray;
            //el.StrokeThickness = 3;
            //el.Fill = clr;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Triangle;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            tr = true;
            sq = rb = st = ar = elp = cr = pol = kv = false;
            if (statics_class.competition_pict == true)
            {
                f2 = true;
                if (f2 = true && f1 == false && f3 == false)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r2.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f2 = true && f1 == true && f3 == false)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r5.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f2 = true && f1 == false && f3 == true)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r7.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                }
                else if (f2 = true && f1 == true && f3 == true)
                {
                    picturepanel.Children.Clear();
                    string s = dir + "\\Pict\\r9.png";
                    statics_class.filesource = s;
                    Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
                    imgpanel.Source = new BitmapImage(u);
                    msg.get("Ты все завершил! Молодец!");
                    msg.ShowDialog();
                }
            }
                if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\трохкутник.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\треугольник.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\triangle.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }

        private void oval_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 6;
                generate(uc);
            }
            else
            {
              //  brush = Brushes.MintCream;
                drawoval(brush);
            }
        }
        private void drawoval(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region
            //Ellipse el = new Ellipse();
            //el.Width = picturepanel.ActualWidth;
            //el.Height = picturepanel.ActualWidth - 100;
            ////el.Margin = new Thickness(0, el.Height / picturepanel.ActualWidth, 0, 0);
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill = clr;
            //el.Stroke = Brushes.Gray;
            //el.StrokeThickness = 3;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Ellipse;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            elp = true;
            sq = rb = st = ar = tr = cr = pol = kv = false;
            if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\овал.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\овал.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\oval.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }

        private void kvadr_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 9;
                generate(uc);
            }
            else
            {
                //brush = Brushes.MintCream;
                drawkvadrat(brush);
            }
        }

        private void drawkvadrat(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region
            //Rectangle el = new Rectangle();
            //el.Width = picturepanel.ActualHeight / 2;
            //el.Height = picturepanel.ActualHeight / 2;
            //el.Fill = clr;
            //el.Margin = new Thickness(0, picturepanel.ActualHeight / 4, 0, 0);
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill = clr;
            //el.Stroke = Brushes.Gray;
            //el.StrokeThickness = 3;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Square;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            kv = true;
            sq = rb = st = ar = elp = tr = pol = cr = false;
            if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\квадрат.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\квадрат.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\square.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }
        private void fiveugol_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 8;
                generate(uc);
            }
            else
            {
              //  brush = Brushes.MintCream;
                drawkfiveugol(brush);
            }
        }
        
        private void drawkfiveugol(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region
            //Polygon el = new Polygon();
            //System.Windows.Point Point1 = new System.Windows.Point(picturepanel.ActualWidth / 2, 0);
            //System.Windows.Point Point2 = new System.Windows.Point(picturepanel.ActualWidth / 2 + 100, picturepanel.ActualHeight / 5);
            //System.Windows.Point Point3 = new System.Windows.Point(picturepanel.ActualWidth / 2 + 70, picturepanel.ActualHeight / 2);
            //System.Windows.Point Point4 = new System.Windows.Point(picturepanel.ActualWidth / 2 - 70, picturepanel.ActualHeight / 2);
            //System.Windows.Point Point5 = new System.Windows.Point(picturepanel.ActualWidth / 2 - 100, picturepanel.ActualHeight / 5);
            //PointCollection myPointCollection = new PointCollection();
            //myPointCollection.Add(Point1);
            //myPointCollection.Add(Point2);
            //myPointCollection.Add(Point3);
            //myPointCollection.Add(Point4);
            //myPointCollection.Add(Point5);
            //el.Points = myPointCollection;
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill = clr;
            //el.Stroke = Brushes.Gray;
            //MessageBox.Show( el.Points.Count().ToString());
            //MessageBox.Show(myPointCollection[0].X.ToString()+"; "+ myPointCollection[0].Y.ToString());
            //MessageBox.Show(myPointCollection[1].X.ToString() + "; " + myPointCollection[1].Y.ToString());
            //MessageBox.Show(myPointCollection[2].X.ToString() + "; " + myPointCollection[2].Y.ToString());
            //MessageBox.Show(myPointCollection[3].X.ToString() + "; " + myPointCollection[3].Y.ToString());
            //MessageBox.Show(myPointCollection[4].X.ToString() + "; " + myPointCollection[4].Y.ToString());
            //el.StrokeThickness = 3;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Pentagon;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            pol = true;
            sq = rb = st = ar = elp = tr = cr = kv = false;
            if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\пятикутник.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\пятиугольник.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\pentagon.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }

        private void romb_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 3;
                generate(uc);
            }
            else
            {
               // brush = Brushes.MintCream;
                drawromb(brush);
            }
        }
        private void drawromb(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region
            //Rectangle el = new Rectangle();
            //el.Width = picturepanel.ActualWidth / 2;
            //el.Height = picturepanel.ActualWidth / 2;
            //var skewTransform = new SkewTransform(45, 0, picturepanel.ActualWidth, picturepanel.ActualWidth);
            //var rotatetr = new RotateTransform(45, 45, 180);
            //el.RenderTransform = rotatetr;
            ////el.LayoutTransform = skewTransform;
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill =clr;
            //el.Stroke = Brushes.Gray;
            //el.StrokeThickness = 3;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Rhombus;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            rb = true;
            sq = cr = st = ar = elp = tr = pol = kv = false;
            if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\ромб.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\ромб.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\rombes.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }
        private void choose()
        {
            if (cr == true)
                drawcircle(brush);
            if (sq == true)
                drawsquare(brush);
            if (rb == true)
                drawromb(brush);
            if (elp == true)
                drawoval(brush);
            if (tr == true)
                drawtriangle(brush);
            if (pol == true)
                drawkfiveugol(brush);
            if (kv == true)
                drawkvadrat(brush);
            if (ar == true)
                drawarrow(brush);
            if (st == true)
                drawstar(brush);
        }
     

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            System.Windows.Application.Current.Shutdown();
        }

        private void drawarrow(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region

            //Line el = new Line();
            //el.X1 = picturepanel.ActualWidth / 4+100;
            //el.Y1= picturepanel.ActualHeight / 4;
            //el.X2 = picturepanel.ActualWidth / 2+100;
            //el.Y2 = picturepanel.ActualHeight / 2;
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Stroke =clr;
            //el.StrokeThickness = 10;
            //picturepanel.Children.Add(el);
            //Line el1 = new Line();
            //el1.X1 = picturepanel.ActualWidth / 4+18 ;
            //el1.Y1 = picturepanel.ActualHeight / 2;
            //el1.X2 = picturepanel.ActualWidth / 2+18 ;
            //el1.Y2 = picturepanel.ActualHeight / 4;
            //el1.VerticalAlignment = VerticalAlignment.Center;
            //el1.HorizontalAlignment = HorizontalAlignment.Center;
            //el1.Stroke = clr;
            //el1.StrokeThickness = 10;
            //picturepanel.Children.Add(el1);
            //Line el2 = new Line();
            //el2.X1 = picturepanel.ActualWidth / 4+100 ;
            //el2.Y1 = picturepanel.ActualHeight / 4;
            //el2.X2 = picturepanel.ActualWidth / 4+100 ;
            //el2.Y2 = picturepanel.ActualHeight / 4+200;
            //el2.VerticalAlignment = VerticalAlignment.Center;
            //el2.HorizontalAlignment = HorizontalAlignment.Center;
            //el2.Stroke = clr;
            //el2.StrokeThickness = 10;
            //picturepanel.Children.Add(el2);
#endregion

            p.Kind = PackIconKind.ArrowTop;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            ar = true;
            sq = rb = st = pol = elp = tr = cr = kv = false;
            if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\стрэлка.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\стрелка.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\arrow.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }
        private void strel_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 5;
                generate(uc);
            }
            else
            {
              //  brush = Brushes.MintCream;
                drawarrow(brush);
            }
        }
        private void drawstar(SolidColorBrush clr)
        {
            picturepanel.Children.Clear();
            #region
            //Polygon el = new Polygon();
            //System.Windows.Point Point1 = new System.Windows.Point(picturepanel.ActualWidth / 2, 0);
            //System.Windows.Point Point2 = new System.Windows.Point(picturepanel.ActualWidth / 2 + 100, picturepanel.ActualHeight / 5);
            //System.Windows.Point Point3 = new System.Windows.Point(picturepanel.ActualWidth / 2 + 70, picturepanel.ActualHeight / 2);
            //System.Windows.Point Point4 = new System.Windows.Point(picturepanel.ActualWidth / 2 - 70, picturepanel.ActualHeight / 2);
            //System.Windows.Point Point5 = new System.Windows.Point(picturepanel.ActualWidth / 2 - 100, picturepanel.ActualHeight / 5);
            //PointCollection myPointCollection = new PointCollection();
            //myPointCollection.Add(Point1);
            //myPointCollection.Add(Point2);
            //myPointCollection.Add(Point3);
            //myPointCollection.Add(Point4);
            //myPointCollection.Add(Point5);
            //el.Points = myPointCollection;
            //el.VerticalAlignment = VerticalAlignment.Center;
            //el.HorizontalAlignment = HorizontalAlignment.Center;
            //el.Fill = clr;
            //el.Stroke = Brushes.Gray;
            //MessageBox.Show( el.Points.Count().ToString());
            //MessageBox.Show(myPointCollection[0].X.ToString()+"; "+ myPointCollection[0].Y.ToString());
            //MessageBox.Show(myPointCollection[1].X.ToString() + "; " + myPointCollection[1].Y.ToString());
            //MessageBox.Show(myPointCollection[2].X.ToString() + "; " + myPointCollection[2].Y.ToString());
            //MessageBox.Show(myPointCollection[3].X.ToString() + "; " + myPointCollection[3].Y.ToString());
            //MessageBox.Show(myPointCollection[4].X.ToString() + "; " + myPointCollection[4].Y.ToString());
            //el.StrokeThickness = 3;
            //picturepanel.Children.Add(el);
            #endregion
            p.Kind = PackIconKind.Star;
            p.Width = picturepanel.ActualWidth;
            p.Height = picturepanel.ActualWidth;
            p.Foreground = clr;
            picturepanel.Children.Add(p);
            st = true;
            sq = rb = pol = ar = elp = tr = cr = kv = false;
            if (lang == 0)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\BLR\зорка.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1000);
                string s = @"\Sound\Figures\RUS\звезда.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                if (brush == Brushes.LightGray)
                    Thread.Sleep(0);
                else
                    Thread.Sleep(1700);
                string s = @"\Sound\Figures\US\star.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
        }
        private void star_button_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.competition == true)
            {
                uc = 4;
                generate(uc);
            }
            else
            {
              //  brush = Brushes.MintCream;
                drawstar(brush);
            }
        }

        private void PackIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            butexit.Foreground = Brushes.Red;
        }

        private void butexit_MouseLeave(object sender, MouseEventArgs e)
        {
            butexit.Foreground = Brushes.DarkRed;
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            about w = new about();
            w.Show();
        }
        void choose_color()
        {
            kc = rnd.Next(1, 12);
            switch (kc)
            {
                case 1:
                    brush = Brushes.Red;
                    break;
                case 2:
                    brush = Brushes.Orange;
                    break;
                case 3:
                    brush = Brushes.Yellow;
                    break;
                case 4:
                    brush = Brushes.Green;
                    break;
                case 5:
                    brush = Brushes.SkyBlue;
                    break;
                case 6:
                    brush = Brushes.Blue;
                    break;
                case 7:
                    brush = Brushes.Purple;
                    break;
                case 8:
                    brush = Brushes.White;
                    break;
                case 9:
                    brush = Brushes.Firebrick;
                    break;
                case 10:
                    brush = Brushes.Gray;
                    break;
                case 11:
                    brush = Brushes.Black;
                    break;
                case 12:
                    brush = Brushes.DeepPink;
                    break;
            }
        }
        void choose_figure(int k)
        {

            switch (k)
            {
                case 1:
                    drawcircle(brush);
                    break;
                case 2:
                    drawsquare(brush);
                    break;
                case 3:
                    drawromb(brush);
                    break;
                case 4:
                    drawstar(brush);
                    break;
                case 5:
                    drawarrow(brush);
                    break;
                case 6:
                    drawoval(brush);
                    break;
                case 7:
                    drawtriangle(brush);
                    break;
                case 8:
                    drawkfiveugol(brush);
                    break;
                case 9:
                    drawkvadrat(brush);
                    break;
            }
        }
        private void test_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (statics_class.create_picttest == false || statics_class.competition == true)
                {
                    if (statics_class.create_picttest == true || statics_class.competition_pict == true)
                        return;
                    statics_class.create = true;
                    test_view f = new test_view();
                    var rez=f.ShowDialog();
                    statics_class.wnddialoh = (bool)rez;
                }
                else return;
                if (statics_class.wnddialoh == false)
                    return;
                if (statics_class.competition == false)
                {
                    picturepanel.Children.Clear();
                    compcont.Text = "";
                    compcount=comperrcouunt = 0;
                    statics_class.check_color = statics_class.check_competition= false;
                    brush = Brushes.LightGray;
                    return;
                }
                if (statics_class.check_color == false)
                    brush = Brushes.Gray;
                else
                {
                    choose_color();
                }
                kf = rnd.Next(1, statics_class.cout_figure);
                choose_figure(kf);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictest_Click(object sender, RoutedEventArgs e)
        {
            if (statics_class.create_picttest == false|| statics_class.competition_pict==true)
            {
                if (statics_class.create == true || statics_class.competition == true)
                    return;
                statics_class.create_picttest = true;
                Picture_test_view f = new Picture_test_view();
                var rez = f.ShowDialog();
                statics_class.wnddialoh = (bool)rez;

            }
            else return;
            if (statics_class.wnddialoh == false)
                return;
            if (statics_class.competition_pict == false)
            {
               picturepanel.Children.Clear();
               imgpanel.Visibility = Visibility.Hidden;
               picturepanel.Visibility = Visibility.Visible;
                f1 = f2 = f3 = false;
                return;
            }
            picturepanel.Children.Clear();
            imgpanel.Visibility = Visibility.Visible;
            picturepanel.Visibility = Visibility.Hidden;
            string s = dir + "\\Pict\\r1.png";
            //MessageBox.Show(s);
            statics_class.filesource = s;
            Uri u = new Uri(statics_class.filesource, UriKind.RelativeOrAbsolute);
            imgpanel.Source = new BitmapImage(u);
        }
        #region color_click
        private void red_clr_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lang == 0)
                {   
                    if(ar==true||st==true)
                        s = @"\Sound\Colors\BLR\чырвоная.wav";
                else
                     s = @"\Sound\Colors\BLR\чырвоны.wav";
                    sp.Open(new Uri(dir + s, UriKind.Absolute));
                    sp.Play();
                }
                else if(lang==1)
                {
                    if (ar == true || st == true)
                        s = @"\Sound\Colors\RUS\красная.wav";
                    else
                        s = @"\Sound\Colors\RUS\красный.wav";
                    sp.Open(new Uri(dir + s, UriKind.Absolute));
                    sp.Play();
                }
                else if(lang==2)
                {
                    string s = @"\Sound\Colors\US\red.aac";
                    sp.Open(new Uri(dir + s, UriKind.Absolute));
                    sp.Play();
                }
                brush = Brushes.Red;
                choose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void orange_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\аранжавая.wav";
                else
                    s = @"\Sound\Colors\BLR\аранжавы.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\оранжевая.wav";
                else
                     s = @"\Sound\Colors\RUS\оранжевый.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\orange.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Orange;
            choose();
        }

        private void green_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\зялёная.wav";
                else
                     s = @"\Sound\Colors\BLR\зялёны.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\зелёная.wav";
                else
                     s = @"\Sound\Colors\RUS\зелёный.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\green.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Green;
            choose();
        }

        private void yellow_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\жоутая.wav";
                else
                     s = @"\Sound\Colors\BLR\жоуты.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\жёлтая.wav";
                else
                     s = @"\Sound\Colors\RUS\жёлтый.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\yellow.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Yellow;
            choose();
        }

        private void lightbl_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\блакитная.wav";
                else
                     s = @"\Sound\Colors\BLR\блакитны.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\голубая.wav";
                else
                     s = @"\Sound\Colors\RUS\голубой.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\light_blue.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.SkyBlue;
            choose();
        }

        private void blue_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\синяя.wav";
                else
                     s = @"\Sound\Colors\BLR\сини.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\синяя.wav";
                else
                     s = @"\Sound\Colors\RUS\синий.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\blue.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Blue;
            choose();
        }

        private void violet_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\фиялетавая.wav";
                else
                     s = @"\Sound\Colors\BLR\фиялетавы.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\фиолетовая.wav";
                else
                     s = @"\Sound\Colors\RUS\фиолетовый.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\purple.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Purple;
            choose();
        }

        private void white_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\белая.wav";
                else
                     s = @"\Sound\Colors\BLR\белы.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\белая.wav";
                else
                     s = @"\Sound\Colors\RUS\белый.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\white.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.White;
            choose();
        }

        private void brown_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\карычневая.wav";
                else
                     s = @"\Sound\Colors\BLR\карычневы.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\коричневая.wav";
                else
                     s = @"\Sound\Colors\RUS\коричневый.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\brown.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Firebrick;
            choose();
        }

        private void gray_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\шэрая.wav";
                else
                     s = @"\Sound\Colors\BLR\шэры.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\серая.wav";
                else
                     s = @"\Sound\Colors\RUS\серый.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\gray.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Gray;
            choose();
        }

        private void black_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\чорная.wav";
                else
                     s = @"\Sound\Colors\BLR\чорны.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\черная.wav";
                else
                     s = @"\Sound\Colors\RUS\черный.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\black.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.Black;
            choose();
        }

        private void pink_clr_button_Click(object sender, RoutedEventArgs e)
        {
            if (lang == 0)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\BLR\ружовая.wav";
                else
                     s = @"\Sound\Colors\BLR\ружовы.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 1)
            {
                if (ar == true || st == true)
                    s = @"\Sound\Colors\RUS\розовая.wav";
                else
                     s = @"\Sound\Colors\RUS\розовый.wav";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            else if (lang == 2)
            {
                string s = @"\Sound\Colors\US\pink.aac";
                sp.Open(new Uri(dir + s, UriKind.Absolute));
                sp.Play();
            }
            brush = Brushes.DeepPink;
            choose();
        }

        #endregion

    }
}
