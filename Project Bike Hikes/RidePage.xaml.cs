using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

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

        private void City_Initialized1(object sender, EventArgs e)
        {
            City1.Text = $"{actual.City[0]}";
        }

        private void City_Initialized2(object sender, EventArgs e)
        {
            City2.Text = $"     {actual.City[1]}\n     ({actual.Size}km)   ";
        }

        private void Description_Initialized(object sender, EventArgs e)
        {
            string diff = actual.Diff.First().ToString();
            for (int i = 1; i < actual.Diff.Count - 1; i++) diff += " and " + actual.Diff.ElementAt(i).ToString();
            string bike = actual.Type.First().ToString();
            for (int i = 1; i < actual.Type.Count - 1; i++) bike += " and " + actual.Type.ElementAt(i).ToString();
            string weather = actual.Weather.First().ToString();
            for (int i = 1; i < actual.Weather.Count - 1; i++) bike += " and " + actual.Weather.ElementAt(i).ToString();
            string crowds = actual.Crowds.First().ToString();
            for (int i = 1; i < actual.Crowds.Count - 1; i++) crowds += " and " + actual.Crowds.ElementAt(i).ToString();
            string type = actual.Type.First().ToString();
            for (int i = 1; i < actual.Type.Count - 1; i++) type += " and " + actual.Type.ElementAt(i).ToString();

            Description.Text =
                $"\nThe ride of {actual.Name} is a beautiful route across {actual.Country}." +
                $"\nIt starts in the city of {actual.City[0]} and ends in {actual.City[1]}. " +
                $"It is a {actual.Size} km ride ({actual.Size * 0.6} miles)." +
                $"\n\nThe recommended bike type for this ride is a {bike} bike, and its difficulty is considered {diff}. " +
                $"\nThe typical weather is {weather}, but it can vary, so don’t forget to check before you go." +
                $"\n\nCrowd levels are generally {crowds}, and due to the terrain, it is recommended to use a {type}." +
                $"\nThe {actual.Name} ride is recommended by other users {actual.Score * 10}% of the time.";

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var existing = Data.favorit.FirstOrDefault(r => r.Name == actual.Name);

            if (existing == null)
            {
                Data.favorit.Add(actual);  
            }
            else
            {
                Data.favorit.Remove(existing);
            }
        }

        private void IsSave_Change(object sender, TextChangedEventArgs e)
        {
            var existing = Data.favorit.FirstOrDefault(r => r.Name == actual.Name);

            if (existing == null)
            {
                IsSave.Text = "Add to favorites";
            }
            else
            {
                IsSave.Text = "Remove to favorites";
            }
        }

        private void Description1_Initialized(object sender, EventArgs e)
        {

            Description1.Text =
                "As always, be careful on the road. " +
                "Make sure you have proper equipment and, if possible, ride with someone or share your location." +
                "\n\nRIDE SAFE";

        }
    }
}
