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
                Name = "Wild Atlantic Way – Sligo Coast",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Road, BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Sunny, Weather.Cloudy },
                BestTime = "9AM to 8PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|54.272,-8.514|54.30,-8.60|54.34,-8.55&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 9,
                Country = Country.Ireland
            };

            Ride r2 = new Ride()
            {
                Name = "Great Western Greenway – Mayo",
                Diff = new List<Difficulty> { Difficulty.Easy, Difficulty.Low },
                Type = new List<BikeType> { BikeType.Hybrid, BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Windy },
                BestTime = "10AM to 6PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.93,-9.30|53.94,-9.50|53.96,-9.80&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 8,
                Country = Country.Ireland
            };

            Ride r3 = new Ride()
            {
                Name = "Lough Gill Loop – Sligo/Leitrim",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Few },
                Weather = new List<Weather> { Weather.Sunny },
                BestTime = "8AM to 5PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|54.26,-8.43|54.26,-8.37|54.29,-8.34&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 2,
                Country = Country.Ireland
            };

            Ride r4 = new Ride()
            {
                Name = "Phoenix Park Loop – Dublin",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Hybrid, BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Sunny },
                BestTime = "7AM to 9PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.355,-6.330|53.357,-6.340|53.360,-6.355&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 1,
                Country = Country.Ireland
            };

            Ride r5 = new Ride()
            {
                Name = "Howth Cliff & Village Ride",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Sunny, Weather.Windy },
                BestTime = "8AM to 7PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.387,-6.063|53.394,-6.058|53.384,-6.046&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 5,
                Country = Country.Ireland
            };

            Ride r6 = new Ride()
            {
                Name = "Ring of Kerry (Short Killarney Loop)",
                Diff = new List<Difficulty> { Difficulty.Medium, Difficulty.Hard },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Cloudy },
                BestTime = "9AM to 6PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|52.06,-9.52|52.03,-9.56|52.01,-9.48&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 6,
                Country = Country.Ireland
            };

            Ride r7 = new Ride()
            {
                Name = "Blessington Lakes Loop – Wicklow",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Sunny },
                BestTime = "8AM to 7PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.17,-6.52|53.15,-6.48|53.18,-6.45&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 4,
                Country = Country.Ireland
            };

            Ride r8 = new Ride()
            {
                Name = "Waterford Greenway",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Windy },
                BestTime = "9AM to 8PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|52.24,-7.12|52.20,-7.18|52.17,-7.27&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 8,
                Country = Country.Ireland
            };

            Ride r9 = new Ride()
            {
                Name = "Galway to Salthill Coastal Path",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Sunny, Weather.Windy },
                BestTime = "10AM to 9PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.27,-9.06|53.26,-9.08|53.26,-9.12&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 7,
                Country = Country.Ireland
            };

            Ride r10 = new Ride()
            {
                Name = "Connemara Loop – Clifden Sky Road",
                Diff = new List<Difficulty> { Difficulty.Medium, Difficulty.Hard },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Few },
                Weather = new List<Weather> { Weather.Sunny },
                BestTime = "8AM to 5PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.49,-10.02|53.50,-10.06|53.51,-10.02&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 6,
                Country = Country.Ireland
            };

            Ride r11 = new Ride()
            {
                Name = "Achill Island Coast to Keem Bay",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Windy, Weather.Sunny },
                BestTime = "9AM to 6PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.97,-10.02|53.97,-10.08|53.96,-10.12&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 4,
                Country = Country.Ireland
            };

            Ride r12 = new Ride()
            {
                Name = "Cliffs of Moher Coastal Cycle",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Sunny, Weather.Cloudy },
                BestTime = "9AM to 6PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|52.97,-9.43|52.99,-9.44|52.98,-9.41&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 3,
                Country = Country.Ireland
            };

            Ride r13 = new Ride()
            {
                Name = "Dingle Peninsula Slea Head Loop",
                Diff = new List<Difficulty> { Difficulty.Hard },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Sunny },
                BestTime = "8AM to 6PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|52.12,-10.44|52.13,-10.48|52.10,-10.50&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 7,
                Country = Country.Ireland
            };

            Ride r14 = new Ride()
            {
                Name = "Boyne Valley Heritage Route",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Cloudy },
                BestTime = "9AM to 7PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.70,-6.45|53.69,-6.40|53.72,-6.36&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 5,
                Country = Country.Ireland
            };

            Ride r15 = new Ride()
            {
                Name = "Limerick Greenway",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Cloudy },
                BestTime = "8AM to 8PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|52.45,-9.06|52.44,-9.13|52.42,-9.19&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 6,
                Country = Country.Ireland
            };

            Ride r16 = new Ride()
            {
                Name = "Glenveagh National Park Loop – Donegal",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Mountain, BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Few },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Windy },
                BestTime = "9AM to 5PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|55.03,-7.99|55.02,-7.95|55.04,-7.93&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 9,
                Country = Country.Ireland
            };

            Ride r17 = new Ride()
            {
                Name = "Causeway Coast Ride – Antrim",
                Diff = new List<Difficulty> { Difficulty.Medium, Difficulty.Hard },
                Type = new List<BikeType> { BikeType.Road },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Sunny, Weather.Windy },
                BestTime = "10AM to 7PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|55.24,-6.51|55.25,-6.55|55.23,-6.57&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 2,
                Country = Country.Ireland
            };

            Ride r18 = new Ride()
            {
                Name = "River Shannon Blueway – Leitrim",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Hybrid, BikeType.Mountain },
                Crowds = new List<Crowds> { Crowds.Few },
                Weather = new List<Weather> { Weather.Cloudy },
                BestTime = "8AM to 7PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|53.99,-8.07|53.98,-8.11|54.00,-8.14&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 1,
                Country = Country.Ireland
            };

            Ride r19 = new Ride()
            {
                Name = "Killarney National Park Cycle",
                Diff = new List<Difficulty> { Difficulty.Easy },
                Type = new List<BikeType> { BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Many },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Sunny },
                BestTime = "9AM to 6PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|52.04,-9.51|52.05,-9.56|52.02,-9.54&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 0,
                Country = Country.Ireland
            };

            Ride r20 = new Ride()
            {
                Name = "Strandhill to Knocknarea Loop – Sligo",
                Diff = new List<Difficulty> { Difficulty.Medium },
                Type = new List<BikeType> { BikeType.Road, BikeType.Hybrid },
                Crowds = new List<Crowds> { Crowds.Some },
                Weather = new List<Weather> { Weather.Cloudy, Weather.Sunny },
                BestTime = "8AM to 8PM",
                Map = "https://maps.googleapis.com/maps/api/staticmap?size=800x600&path=weight:4|color:blue|54.27,-8.59|54.25,-8.54|54.26,-8.51&key=AIzaSyCpIYhDnAimS9vL99Agdi413yk3OvKH3FM",
                Score = 3,
                Country = Country.Ireland
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
            list.Add(r11);
            list.Add(r12);
            list.Add(r13);
            list.Add(r14);
            list.Add(r15);
            list.Add(r16);
            list.Add(r17);
            list.Add(r18);
            list.Add(r19);
            list.Add(r20);

            return list;

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            double nb = rnd.Next(70);
            BackgroundVideo.Position = TimeSpan.FromSeconds(nb);
            BackgroundVideo.Play();

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

            BestMatchListBox.ItemsSource = filtered.Select(r => r.Name).ToList();
        }

        private void DiffBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }


        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            double nb = rnd.Next();
            BackgroundVideo.Position = TimeSpan.FromSeconds(nb);
            BackgroundVideo.Play();       
        }

        private void BestMatchListBox_Selected(object sender, RoutedEventArgs e) { }

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
                if (Trending.SelectedItem == ride.Name )
                {
                    
                    var page = new RidePage(ride);
                    page.Show();
                    this.Close();
                }
            }
        }
    }

}
