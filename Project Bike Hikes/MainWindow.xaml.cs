using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Project_Bike_Hikes
{

    public partial class MainWindow : Window
    {

        List<Ride> list;

        public MainWindow()
        {
            InitializeComponent();

            DiffBox.ItemsSource = Enum.GetValues(typeof(Difficulty));
            DiffBox_Copy.ItemsSource = Enum.GetValues(typeof(BikeType));
            DiffBox_Copy1.ItemsSource = Enum.GetValues(typeof(Weather));
            DiffBox_Copy3.ItemsSource = Enum.GetValues(typeof(Crowds));
            LangBox.ItemsSource = Enum.GetValues(typeof(Country));
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            double nb = rnd.Next(70);
            BackgroundVideo.Position = TimeSpan.FromSeconds(nb);
            BackgroundVideo.Play();

            list = new List<Ride>();
            list = Data.load_ride(list);
            DiffBox.SelectionChanged += FilterRides;
            DiffBox_Copy.SelectionChanged += FilterRides;
            DiffBox_Copy1.SelectionChanged += FilterRides;
            DiffBox_Copy3.SelectionChanged += FilterRides;
            LangBox.SelectionChanged += FilterRides;

            var trending = list.AsEnumerable();
            Trending.ItemsSource = trending.Where(r => r.Score > 9).Select(r => r.Name).ToList();

            History.ItemsSource = Data.history.Select(r => r.Name).ToList();
        }

        private void FilterRides(object sender, SelectionChangedEventArgs e)
        {
            if (list == null || list.Count == 0) return;
            var filtered = list.AsEnumerable();

            if (DiffBox.SelectedItem is Difficulty diff)
                filtered = filtered.Where(r => r.Diff.Contains(diff));
            if (DiffBox_Copy.SelectedItem is BikeType type)
                filtered = filtered.Where(r => r.Type.Contains(type));
            if (DiffBox_Copy1.SelectedItem is Weather weather)
                filtered = filtered.Where(r => r.Weather.Contains(weather));
            if (DiffBox_Copy3.SelectedItem is Crowds crowd)
                filtered = filtered.Where(r => r.Crowds.Contains(crowd));
            if (LangBox.SelectedItem is Country country)
                filtered = filtered.Where(r => r.Country.Equals(country));

            BestMatchListBox.ItemsSource = filtered.Select(r => r.Name).ToList();

            var remaining = filtered.ToList();
            var diffValues = remaining.SelectMany(r => r.Diff).Distinct().ToList();
            if (DiffBox.SelectedItem == null)
                DiffBox.ItemsSource = diffValues;

            var typeValues = remaining.SelectMany(r => r.Type).Distinct().ToList();
            if (DiffBox_Copy.SelectedItem == null)
                DiffBox_Copy.ItemsSource = typeValues;
                
            var weatherValues = remaining.SelectMany(r => r.Weather).Distinct().ToList();
            if (DiffBox_Copy1.SelectedItem == null)
                DiffBox_Copy1.ItemsSource = weatherValues;

            var crowdValues = remaining.SelectMany(r => r.Crowds).Distinct().ToList();
            if (DiffBox_Copy3.SelectedItem == null)
                DiffBox_Copy3.ItemsSource = crowdValues;
        }

        private void DiffBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }


        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            double nb = rnd.Next();
            BackgroundVideo.Position = TimeSpan.Zero;
            BackgroundVideo.Play();       
        }

        private void BestMatchListBox_Selected(object sender, RoutedEventArgs e) { }

        private void BestMatchListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(Ride ride in list) {
                if (BestMatchListBox.SelectedItem == ride.Name)
                {
                    var page = new RidePage(ride);
                    if (!Data.history.Any(r => r.Name == ride.Name)) Data.history.Add(ride);
                    page.Show();
                    this.Close();
                }
            }
        }

        private void Trending_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            foreach (Ride ride in list)
            {
                if (Trending.SelectedItem == ride.Name )
                {
                    
                    var page = new RidePage(ride);
                    if (!Data.history.Any(r => r.Name == ride.Name)) Data.history.Add(ride);
                    page.Show();
                    this.Close();
                }
            }
        }

        private void LangBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var trending = list.AsEnumerable();
            if (LangBox.SelectedItem is Country country)
                trending = trending.Where(r => r.Country.Equals(country)).Where(r => r.Score > 9).ToList();

            LangText.Text = null;
            Trending.ItemsSource = trending.OrderBy(r => r.Diff.Min()).Select(r => r.Name).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var profil = new Profil();
            profil.Show();
            this.Close();
        }

        private void his_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
