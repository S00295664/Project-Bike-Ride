using System;
using System.Windows;
using System.Windows.Controls;

namespace Project_Bike_Hikes
{

    public partial class RidePage : Window
    {

        Ride actual;

        public RidePage(Ride ride)
        {
            actual = ride;
            InitializeComponent();
            BackgroundVideo.Play();
        }

        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {

            BackgroundVideo.Position = TimeSpan.Zero;
            BackgroundVideo.Play();

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
    }
}
