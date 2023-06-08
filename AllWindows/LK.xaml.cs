using Microsoft.Win32;
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
   
    public partial class LK : Page
    {
        public LK()
        {
            InitializeComponent();
            bool train1bool = Properties.Settings.Default.Train1bool;
            bool train11legs = Properties.Settings.Default.Train11legs;
            if(train1bool)
            {
                Train1.Visibility= Visibility.Visible;
            }
            if(train11legs)
            {
                Train2.Visibility = Visibility.Visible;
            }

            string filePath = Properties.Settings.Default.avatar;
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                BitmapImage bitmap = new BitmapImage(new Uri(filePath));
                avatar.Source = bitmap;
            }




        }

        private void GoHome(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.mainpage());
        }

        private void But_1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.Page2());
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                BitmapImage bitmap = new BitmapImage(new Uri(filePath));
                avatar.Source = bitmap;
                Properties.Settings.Default.avatar = filePath;
                Properties.Settings.Default.Save();
            }
        }

        private void But_2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.baselegs());
        }
    }
}
