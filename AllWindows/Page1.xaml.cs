using System;
using System.IO;
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

namespace TrainApp.AllWindows
{
    
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            string filePath = Properties.Settings.Default.avatar;
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                BitmapImage bitmap = new BitmapImage(new Uri(filePath));
                avatar.Source = bitmap;
            }
        }

        private void But_1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.Page2());
        }

        private void But_2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButLk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.LK());
        }

        private void GoHome(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.mainpage());
        }
    }
}
