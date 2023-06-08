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
    /// <summary>
    /// Логика взаимодействия для LegsStreet.xaml
    /// </summary>
    public partial class LegsStreet : Page
    {
        public LegsStreet()
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
            NavigationService.Navigate(new AllWindows.baselegs());
        }

        private void GoHome(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.mainpage());
        }

        private void ButLk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.LK());
        }
    }
}
