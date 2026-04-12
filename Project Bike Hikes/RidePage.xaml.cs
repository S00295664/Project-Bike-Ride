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

        private void BIKE_TextChanged(object sender, TextChangedEventArgs e)
        {
            string type = "";
            foreach (var item in actual.Type) type += item.ToString() + " / ";
            BikeType.Text = "Type of Bike Recommanded : " + type;
        }

        private void City_Initialized1(object sender, EventArgs e)
        {
            City1.Text = $"{actual.City[0]}";
        }

        private void City_Initialized2(object sender, EventArgs e)
        {
            City2.Text = $"{actual.City[1]}     ({actual.Size}km)   ";
        }

        private void Weather_Initialized(object sender, EventArgs e)
        {
            string type = "";
            foreach (var item in actual.Weather) type += item.ToString() + " / ";
            Weather.Text = "Weather Recommanded : " + type;
        }

        private void Description_Initialized(object sender, EventArgs e)
        {
            string diff = actual.Diff.First().ToString();
            for (int i = 1; i < actual.Diff.Count - 1; i++) diff += " and " + actual.Diff.ElementAt(i).ToString();
            string bike = actual.Type.First().ToString();
            for (int i = 1; i < actual.Type.Count - 1; i++) bike += " and " + actual.Type.ElementAt(i).ToString();
            string weather = actual.Weather.First().ToString();
            for (int i = 1; i < actual.Weather.Count - 1; i++) bike += " and " + actual.Weather.ElementAt(i).ToString();

            Description.Text = $"The ride of {actual.Name} is a beautiful ride cross the {actual.Country}." +
                $"\nThe Type of bike recommended for this ride is {bike} and this ride difficulty is considered {diff}. " +
                $"\nGenerally, the type of weather is {weather}, but that can change, so dont forget to check before." +
                $"\nThe ride start at the city of {actual.City[0]} and end at {actual.City[1]} : its a {actual.Size}km ({actual.Size* 0.6}miles) ride"
                ;
        }

        private void Score_Init(object sender, EventArgs e)
        {
            Score.Text = $"Recommanded :    {actual.Score}/10";
        }


        private void ScoreBar_Initialized_1(object sender, EventArgs e)
        {
            ScoreBar.Value = actual.Score;
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
                IsSave.Text = "Add from favorits";
            }
            else
            {
                IsSave.Text = "Remove from favorits";
            }
        }
    }
}
