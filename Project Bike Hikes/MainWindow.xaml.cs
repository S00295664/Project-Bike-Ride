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



        }

        public List<Ride> load_ride(List<Ride> list) {

            Ride r1 = new Ride()
            {
                Name = "Coastal Breeze Ride",
                Diff = new List<Difficulty> { Difficulty.Easy, Difficulty.Low },
                Type = new List<BikeType> { BikeType.Road, BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Sunny, Weather.Cloudy },
                BestTime = "8AM to 7PM",
                Map = new Image(),
                Score = 0
            };

            Ride r2 = new Ride()
            {
                Name = "Mountain Peak Challenge",
                Diff = new List<Difficulty> { Difficulty.Hard, Difficulty.Impossible },
                Type = new List<BikeType> { BikeType.Mountain, BikeType.Electric },
                Crowds = new List<Crowds> { Crowds.Nobody, Crowds.Some },
                Weather = new List<Weather> { Weather.Cold, Weather.Foggy },
                BestTime = "6AM to 3PM",
                Map = new Image(),
                Score = 1
            };

            Ride r3 = new Ride()
            {
                Name = "Forest Gravel Loop",
                Diff = new List<Difficulty> { Difficulty.Medium, Difficulty.Hard },
                Type = new List<BikeType> { BikeType.Gravel, BikeType.Mountain },
                Crowds = new List<Crowds> { Crowds.Average },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Humid },
                BestTime = "9AM to 6PM",
                Map = new Image(),
                Score = 2
            };

            Ride r4 = new Ride()
            {
                Name = "City Sunrise Ride",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Road, BikeType.Electric },
                Crowds = new List<Crowds> { Crowds.Lot },
                Weather = new List<Weather> { Weather.Sunny, Weather.Cloudy },
                BestTime = "5AM to 9AM",
                Map = new Image(),
                Score = 3
            };

            Ride r5 = new Ride()
            {
                Name = "Desert Heat Trail",
                Diff = new List<Difficulty> { Difficulty.Medium, Difficulty.Hard },
                Type = new List<BikeType> { BikeType.Mountain, BikeType.Gravel },
                Crowds = new List<Crowds> { Crowds.Nobody },
                Weather = new List<Weather> { Weather.Hot, Weather.Sunny },
                BestTime = "6AM to 11AM",
                Map = new Image(),
                Score = 4
            };

            Ride r6 = new Ride()
            {
                Name = "Foggy Cliffside Route",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road, BikeType.Gravel },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Foggy, Weather.Cloudy },
                BestTime = "10AM to 5PM",
                Map = new Image(),
                Score = 5
            };

            Ride r7 = new Ride()
            {
                Name = "Forest Adventure MTB",
                Diff = new List<Difficulty> { Difficulty.Medium, Difficulty.Hard },
                Type = new List<BikeType> { BikeType.Mountain },
                Crowds = new List<Crowds> { Crowds.Some, Crowds.Nobody },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Rainy },
                BestTime = "9AM to 4PM",
                Map = new Image(),
                Score = 6
            };

            Ride r8 = new Ride()
            {
                Name = "Riverside Zen Path",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Hybrid, BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Average },
                Weather = new List<Weather> { Weather.Sunny, Weather.Cloudy },
                BestTime = "11AM to 8PM",
                Map = new Image(),
                Score = 7
            };

            Ride r9 = new Ride()
            {
                Name = "Urban Night Ride",
                Diff = new List<Difficulty> { Difficulty.Low, Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road, BikeType.Electric },
                Crowds = new List<Crowds> { Crowds.Lot, Crowds.Impossible },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Humid },
                BestTime = "7PM to 11PM",
                Map = new Image(),
                Score = 8
            };

            Ride r10 = new Ride()
            {
                Name = "BMX Park Fun Line",
                Diff = new List<Difficulty> { Difficulty.Medium, Difficulty.Hard },
                Type = new List<BikeType> { BikeType.BMX },
                Crowds = new List<Crowds> { Crowds.Average, Crowds.Lot },
                Weather = new List<Weather> { Weather.Sunny, Weather.Cold },
                BestTime = "12PM to 6PM",
                Map = new Image(),
                Score = 9
            };

            list.Add(r1);
            list.Add(r2);
            list.Add(r3);
            list.Add(r4);
            list.Add(r5);
            list.Add(r6);
            list.Add(r7);
            list.Add(r8);
            list.Add(r9);
            list.Add(r10);

            return list;

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            double nb = rnd.Next(70);
            
            BackgroundVideo.Position = TimeSpan.FromSeconds(nb);
            BackgroundVideo.Play();

            list = new List<Ride>();

            list = load_ride(list);

            DiffBox.SelectionChanged += FilterRides;
            DiffBox_Copy.SelectionChanged += FilterRides;
            DiffBox_Copy1.SelectionChanged += FilterRides;
            DiffBox_Copy3.SelectionChanged += FilterRides;


            var trending = list.AsEnumerable();
            Trending.ItemsSource = trending.Where(r => r.Score > 5).Select(r => r.Name).ToList();

        }





        private void FilterRides(object sender, SelectionChangedEventArgs e)
        {
            if (list == null || list.Count == 0)
                return;

            var filtered = list.AsEnumerable();

            
            if (DiffBox.SelectedItem is Difficulty diff)
                filtered = filtered.Where(r => r.Diff.Contains(diff));

            
            if (DiffBox_Copy.SelectedItem is BikeType type)
                filtered = filtered.Where(r => r.Type.Contains(type));

            
            if (DiffBox_Copy1.SelectedItem is Weather weather)
                filtered = filtered.Where(r => r.Weather.Contains(weather));

            
            if (DiffBox_Copy3.SelectedItem is Crowds crowd)
                filtered = filtered.Where(r => r.Crowds.Contains(crowd));

            
            BestMatchListBox.ItemsSource = filtered.Select(r => r.Name).ToList();
        }

        private void DiffBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            double nb = rnd.Next();
            BackgroundVideo.Position = TimeSpan.FromSeconds(nb);
            BackgroundVideo.Play();
            
        }

        private void BestMatchListBox_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void BestMatchListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(Ride ride in list) {
                if (BestMatchListBox.SelectedItem == ride.Name)
                {
                    var page = new RidePage(ride);
                    page.Show();
                    this.Close();
                }
            }
        }

        private void Trending_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            foreach (Ride ride in list)
            {
                if (Trending.SelectedItem == ride.Name)
                {
                    
                    var page = new RidePage(ride);
                    page.Show();
                    this.Close();
                }
            }
        }
    }

}
