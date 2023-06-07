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

namespace TrainApp.AllWindows
{
    /// <summary>
    /// Логика взаимодействия для LK.xaml
    /// </summary>
    public partial class LK : Page
    {
        public LK()
        {
            InitializeComponent();
            bool train1bool = Properties.Settings.Default.Train1bool;
            if(train1bool)
            {
                Train1.Visibility= Visibility.Visible;
            }
        }

        private void GoHome(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.Page1());
        }

        private void But_1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWindows.Page2());
        }
    }
}
