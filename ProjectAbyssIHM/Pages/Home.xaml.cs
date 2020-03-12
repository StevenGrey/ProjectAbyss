using ProjectAbyssIHM.Pages;
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

namespace ProjectAbyssIHM
{
    /// <summary>
    /// Logique d'interaction pour AbyssHome.xaml
    /// </summary>
    public partial class AbyssHome : Page
    {              
        public AbyssHome()
        {
            InitializeComponent();
        }

        /*Cliquer sur le Bouton Calcule des Résultats*/
        private void StartClick(object sender, RoutedEventArgs e)
        {
            Form form = new Form();
            this.NavigationService.Navigate(form);
        }

        /*Cliquer sur le Bouton de Création d'un nouvel élément (Lieu, Seigneur...)*/
        private void newElemClick(object sender, RoutedEventArgs e)
        {
            NewElement element = new NewElement();
            this.NavigationService.Navigate(element);
        }

        /*Cliquer sur le Bouton Option*/
        private void OptClick(object sender, RoutedEventArgs e)
        {
            Config config = new Config();
            this.NavigationService.Navigate(config);
        }

        /*Cliquer sur le Bouton Quitter*/
        private void QuitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }        
    }
}
