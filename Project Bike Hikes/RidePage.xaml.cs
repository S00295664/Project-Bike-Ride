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
