using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public bool train1bool;
        public Page2()
        {
            InitializeComponent();
            video1.LoadedBehavior = MediaState.Manual;
            video1.Pause();
            train1bool = Properties.Settings.Default.Train1bool;
            startbutton();

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

        private void Addtomytrains_Click(object sender, RoutedEventArgs e)
        {
            if (train1bool == false)
            {
                Addtomytrains.Content = "Добавлено";
                train1bool = true;
                Properties.Settings.Default.Train1bool = train1bool;
                Properties.Settings.Default.Save();
            }
            else
            {
                Addtomytrains.Content = "Добавить";
                train1bool = false;
                Properties.Settings.Default.Train1bool = train1bool;
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
            if (train1bool == false)
            {
                Addtomytrains.Content = "Добавить";
            }
            else
            {
                Addtomytrains.Content = "Добавлено";
            }
        }
     
    }
}
