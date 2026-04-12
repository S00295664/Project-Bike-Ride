using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Project_Bike_Hikes
{
    public partial class Profil : Window
    {

        List<Ride> list;

        public Profil()
        {
            InitializeComponent();
            list = Data.load_ride(list);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            History.ItemsSource = Data.history.Select(r => r.Name).ToList();
            Favorits.ItemsSource = Data.favorit.Select(r => r.Name).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var page = new MainWindow();
            page.Show();
            this.Close();
        }

        private void Fav_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Ride ride in list)
            {
                if (Favorits.SelectedItem == ride.Name)
                {

                    var page = new RidePage(ride);
                    if (!Data.history.Any(r => r.Name == ride.Name)) Data.history.Add(ride);
                    page.Show();
                    this.Close();
                }
            }
        }

        private void History_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Ride ride in list)
            {
                if (History.SelectedItem == ride.Name)
                {

                    var page = new RidePage(ride);
                    if (!Data.history.Any(r => r.Name == ride.Name)) Data.history.Add(ride);
                    page.Show();
                    this.Close();
                }
            }
        }
    }
}
