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
using System.Windows.Shapes;

namespace Project_Bike_Hikes
{
    /// <summary>
    /// Logique d'interaction pour Profil.xaml
    /// </summary>
    public partial class Profil : Window
    {
        List<Ride> His;
        public Profil()
        {
            InitializeComponent();
            His = Data.history;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var page = new MainWindow();
            page.Show();
            this.Close();
        }

        private void Fav_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void History_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (His == null) His = new List<Ride>();
            if (His.Count != 0) History.ItemsSource = His.Select(r => r.Name).ToList();

        }
    }
}
