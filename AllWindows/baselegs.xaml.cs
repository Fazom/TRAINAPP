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
    /// Логика взаимодействия для baselegs.xaml
    /// </summary>
    public partial class baselegs : Page
    {
        public bool trainlegs11;
        public baselegs()
        {
            InitializeComponent();
            video1.LoadedBehavior = MediaState.Manual;
            video1.Pause();
            string filePath = Properties.Settings.Default.avatar;
            trainlegs11 = Properties.Settings.Default.Train11legs;
            startbutton();
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                BitmapImage bitmap = new BitmapImage(new Uri(filePath));
                avatar.Source = bitmap;
            }
        }

        private void Addtomytrains_Click(object sender, RoutedEventArgs e)
        {
            if (trainlegs11 == false)
            {
                Addtomytrains.Content = "Добавлено";
                trainlegs11 = true;
                Properties.Settings.Default.Train11legs = trainlegs11;
                Properties.Settings.Default.Save();
            }
            else
            {
                Addtomytrains.Content = "Добавить";
                trainlegs11 = false;
                Properties.Settings.Default.Train11legs = trainlegs11;
                Properties.Settings.Default.Save();
            }
        }

        private void ButLk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.LK());
        }

        private void GoHome(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.mainpage());
        }
        public void startbutton()
        {
            if (trainlegs11 == false)
            {
                Addtomytrains.Content = "Добавить";
            }
            else
            {
                Addtomytrains.Content = "Добавлено";
            }
        }

        private void Playbutton(object sender, RoutedEventArgs e)
        {
            video1.Play();
        }

        private void Pausebutton(object sender, RoutedEventArgs e)
        {
            video1.Pause();
        }

        private void RePlaybutton(object sender, RoutedEventArgs e)
        {
            video1.Stop();
            video1.Play();
        }
    }
}
