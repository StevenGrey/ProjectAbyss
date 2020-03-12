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

namespace ProjectAbyssIHM.Pages
{
    /// <summary>
    /// Logique d'interaction pour Config.xaml
    /// </summary>
    public partial class Config : Page
    {
        public Config()
        {
            InitializeComponent();
        }

        private void AllChecked(object sender, RoutedEventArgs e)
        {
            KrakenCheck.IsChecked = true;
            LeviCheck.IsChecked = true;
        }

        private void AllUnchecked(object sender, RoutedEventArgs e)
        {
            KrakenCheck.IsChecked = false;
            LeviCheck.IsChecked = false;
        }

        private void Kraken_Checked(object sender, RoutedEventArgs e)
        {
            if (LeviCheck.IsChecked == true)
                AllCheck.IsChecked = true;
        }

        private void Kraken_Unchecked(object sender, RoutedEventArgs e)
        {
            if (AllCheck.IsChecked == true)
            {
                AllCheck.IsChecked = false;
                LeviCheck.IsChecked = true;
            }
                
        }

        private void Levi_Checked(object sender, RoutedEventArgs e)
        {
            if (KrakenCheck.IsChecked == true)
                AllCheck.IsChecked = true;
        }

        private void Levi_Unchecked(object sender, RoutedEventArgs e)
        {
            if (AllCheck.IsChecked == true)
            {
                AllCheck.IsChecked = false;
                KrakenCheck.IsChecked = true;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
