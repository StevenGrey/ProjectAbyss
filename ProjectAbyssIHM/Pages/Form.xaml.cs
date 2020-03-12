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
    /// Logique d'interaction pour Form.xaml
    /// </summary>
    public partial class Form : Page
    {
        public Form()
        {
            InitializeComponent();
        }

        private void nbLocChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbLocations.Value > 0)
                Locations.Visibility = Visibility.Visible;
            else
                Locations.Visibility = Visibility.Hidden;
        }

        private void nbLordChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbLords.Value > 0)
                Lords.Visibility = Visibility.Visible;
            else
                Lords.Visibility = Visibility.Hidden;
        }

        private void nbAlliesRedChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbAlliesRed.Value > 0)
                piAllieRed.Visibility = Visibility.Visible;
            else
                piAllieRed.Visibility = Visibility.Hidden;
        }

        private void piAllieRedChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void nbAlliesBlueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbAlliesBlue.Value > 0)
                piAllieBlue.Visibility = Visibility.Visible;
            else
                piAllieBlue.Visibility = Visibility.Hidden;
        }

        private void piAllieBlueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void nbAlliesPurpChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbAlliesPurp.Value > 0)
                piAlliePurp.Visibility = Visibility.Visible;
            else
                piAlliePurp.Visibility = Visibility.Hidden;
        }

        private void piAlliePurpChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void nbAlliesYelChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbAlliesYel.Value > 0)
                piAllieYel.Visibility = Visibility.Visible;
            else
                piAllieYel.Visibility = Visibility.Hidden;
        }

        private void piAllieYelChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void nbAlliesGreenChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbAlliesGreen.Value > 0)
                piAllieGreen.Visibility = Visibility.Visible;
            else
                piAllieGreen.Visibility = Visibility.Hidden;
        }

        private void piAllieGreenChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void nbMonsterChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (nbMonster.Value > 0)
                piMonster.Visibility = Visibility.Visible;
            else
                piMonster.Visibility = Visibility.Hidden;
        }

        private void piMonsterChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Result result = new Result();
            this.NavigationService.Navigate(result);
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test");
        }
    }
}
