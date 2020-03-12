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
    /// Logique d'interaction pour NewElement.xaml
    /// </summary>
    public partial class NewElement : Page
    {
        public NewElement()
        {
            InitializeComponent();
        }

        private void YesKeys_Checked(object sender, RoutedEventArgs e)
        {
            nbKey.Visibility = Visibility.Visible;
        }

        private void NoKeys_Checked(object sender, RoutedEventArgs e)
        {
            nbKey.Visibility = Visibility.Hidden;
        }

        private void Lord_Checked(object sender, RoutedEventArgs e)
        {
            if(Lord.IsChecked == true)
            {
                LabKey.Visibility = Visibility.Visible;
                YesKey.Visibility = Visibility.Visible;
                NoKey.Visibility = Visibility.Visible;
                Color.Visibility = Visibility.Visible;
                LabIp.Visibility = Visibility.Visible;
                IpLord.Visibility = Visibility.Visible;

                DescLocation.Visibility = Visibility.Hidden;
            }
        }

        private void Location_Checked(object sender, RoutedEventArgs e)
        {
            if (Location.IsChecked == true)
            {
                DescLocation.Visibility = Visibility.Visible;

                LabKey.Visibility = Visibility.Hidden;
                YesKey.Visibility = Visibility.Hidden;
                NoKey.Visibility = Visibility.Hidden;
                Color.Visibility = Visibility.Hidden;
                LabIp.Visibility = Visibility.Hidden;
                IpLord.Visibility = Visibility.Hidden;
            }
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(DescLocation.Text);
        }
    }
}
