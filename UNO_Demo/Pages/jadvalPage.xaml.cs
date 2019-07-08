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
using System.Collections.ObjectModel;

namespace UNO_Demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для jadvalPage.xaml
    /// </summary>
    public partial class jadvalPage : UserControl
    {
        ObservableCollection<DarsPara> DarsParalar { get; set; }
        DarsJadval dj = new DarsJadval();
        Syncronization sync = new Syncronization();
        public jadvalPage()
        {
            InitializeComponent();

            dj = sync.jadval();


            DarsParalar = new ObservableCollection<DarsPara>();

            //MessageBox.Show(DateTime.Today.DayOfWeek.ToString());
            switch(DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    for (int i = 0; i < dj.Dushanba.Length; i++)
                        DarsParalar.Add(dj.Dushanba[i]);
                    break;
                case "Tuesday":
                    for (int i = 0; i < dj.Seshanba.Length; i++)
                        DarsParalar.Add(dj.Seshanba[i]);
                    break;
                case "Wednesday":
                    for (int i = 0; i < dj.Chorshanba.Length; i++)
                        DarsParalar.Add(dj.Chorshanba[i]);
                    break;
                case "Thursday":
                    for (int i = 0; i < dj.Payshanba.Length; i++)
                        DarsParalar.Add(dj.Payshanba[i]);
                    break;
                case "Friday":
                    for (int i = 0; i < dj.Juma.Length; i++)
                        DarsParalar.Add(dj.Juma[i]);
                    break;
                case "Saturday":
                    for (int i = 0; i < dj.Shanba.Length; i++)
                        DarsParalar.Add(dj.Shanba[i]);
                    break;
                default:
                    for (int i = 0; i < dj.Dushanba.Length; i++)
                        DarsParalar.Add(dj.Dushanba[i]);
                    break;
            }
            paraList.ItemsSource = DarsParalar;
        }

        private void btnDushanba_Click(object sender, RoutedEventArgs e)
        {
            DarsParalar.Clear();
            for (int i = 0; i < dj.Dushanba.Length; i++)
                DarsParalar.Add(dj.Dushanba[i]);
            btnDushanba.Foreground = Brushes.Green;
            btnSeshanba.Foreground = Brushes.Black;
            btnChorshanba.Foreground = Brushes.Black;
            btnPayshanba.Foreground = Brushes.Black;
            btnJuma.Foreground = Brushes.Black;
            btnShanba.Foreground = Brushes.Black;
        }

        private void btnSeshanba_Click(object sender, RoutedEventArgs e)
        {
            DarsParalar.Clear();
            for (int i = 0; i < dj.Seshanba.Length; i++)
                DarsParalar.Add(dj.Seshanba[i]);
            btnDushanba.Foreground = Brushes.Black;
            btnSeshanba.Foreground = Brushes.Green;
            btnChorshanba.Foreground = Brushes.Black;
            btnPayshanba.Foreground = Brushes.Black;
            btnJuma.Foreground = Brushes.Black;
            btnShanba.Foreground = Brushes.Black;
        }

        private void btnChorshanba_Click(object sender, RoutedEventArgs e)
        {
            DarsParalar.Clear();
            for (int i = 0; i < dj.Chorshanba.Length; i++)
                DarsParalar.Add(dj.Chorshanba[i]);
            btnDushanba.Foreground = Brushes.Black;
            btnSeshanba.Foreground = Brushes.Black;
            btnChorshanba.Foreground = Brushes.Green;
            btnPayshanba.Foreground = Brushes.Black;
            btnJuma.Foreground = Brushes.Black;
            btnShanba.Foreground = Brushes.Black;
        }

        private void btnPayshanba_Click(object sender, RoutedEventArgs e)
        {
            DarsParalar.Clear();
            for (int i = 0; i < dj.Payshanba.Length; i++)
                DarsParalar.Add(dj.Payshanba[i]);
            btnDushanba.Foreground = Brushes.Black;
            btnSeshanba.Foreground = Brushes.Black;
            btnChorshanba.Foreground = Brushes.Black;
            btnPayshanba.Foreground = Brushes.Green;
            btnJuma.Foreground = Brushes.Black;
            btnShanba.Foreground = Brushes.Black;
        }

        private void btnJuma_Click(object sender, RoutedEventArgs e)
        {
            DarsParalar.Clear();
            for (int i = 0; i < dj.Juma.Length; i++)
                DarsParalar.Add(dj.Juma[i]);
            btnDushanba.Foreground = Brushes.Black;
            btnSeshanba.Foreground = Brushes.Black;
            btnChorshanba.Foreground = Brushes.Black;
            btnPayshanba.Foreground = Brushes.Black;
            btnJuma.Foreground = Brushes.Green;
            btnShanba.Foreground = Brushes.Black;
        }

        private void btnShanba_Click(object sender, RoutedEventArgs e)
        {
            DarsParalar.Clear();
            for (int i = 0; i < dj.Shanba.Length; i++)
                DarsParalar.Add(dj.Shanba[i]);
            btnDushanba.Foreground = Brushes.Black;
            btnSeshanba.Foreground = Brushes.Black;
            btnChorshanba.Foreground = Brushes.Black;
            btnPayshanba.Foreground = Brushes.Black;
            btnJuma.Foreground = Brushes.Black;
            btnShanba.Foreground = Brushes.Green;
        }
    }

    
}
