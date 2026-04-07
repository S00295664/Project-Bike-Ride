using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Project_Bike_Hikes
{

    public partial class RidePage : Window
    {

        Ride actual;

        public RidePage(Ride ride)
        {
            actual = ride;
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var page = new MainWindow();
            page.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RideName.Text = actual.Name;
        }

        private void BIKE_TextChanged(object sender, TextChangedEventArgs e)
        {
            string type = "";
            foreach (var item in actual.Type) type += item.ToString() + " / ";
            BikeType.Text = "Type of Bike Recommanded : " + type;
        }

        private void MapPreview_Initialized(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(actual.Map))
            {
                Console.WriteLine("No map link provided");
                return;
            }
            MapPreview.Source = new BitmapImage(new Uri(actual.Map));
        }
    }
}
