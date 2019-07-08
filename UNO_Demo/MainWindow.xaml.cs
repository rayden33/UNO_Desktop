using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace UNO_Demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Frame frame;
        private bool leftMenuShow = false;
        public MainWindow()
        {
            InitializeComponent();

            frame = fmMain;
        }

        private void btnLeftMenuShowHide_Click(object sender, RoutedEventArgs e)
        {
            if (leftMenuShow)
            {
                ShowHideMenu("sbHideLeftMenu", btnLeftMenuShowHide, pnlLeftMenu);
                leftMenuShow = false;
            }
            else
            {
                ShowHideMenu("sbShowLeftMenu", btnLeftMenuShowHide, pnlLeftMenu);
                leftMenuShow = true;
            }
            
        }

        private void ShowHideMenu(string Storyboard, Button btnHideShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);
        }

        private void btnNews_Click(object sender, RoutedEventArgs e)
        {
            Pages.newsPage news = new Pages.newsPage();
            frame.Navigate(news);
        }

        private void btnDarsJadval_Click(object sender, RoutedEventArgs e)
        {
            Pages.jadvalPage jadvalPage = new Pages.jadvalPage();
            frame.Navigate(jadvalPage);
        }

        private void btnChiqish_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
