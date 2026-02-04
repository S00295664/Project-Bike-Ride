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
using System.Windows.Navigation;
using System.Windows.Shapes;


// <Image Source="/Ressource/18086706-.jpg" Width="800" Height="450"/>

namespace Project_Bike_Hikes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public enum Difficulty {
        Easy,
        Low,
        Medium,
        Hard,
        Impossible
    }
    public enum BikeType {
        Road,
        Mountain,
        Hybrid,
        Gravel,
        Electric,
        BMX
    }

    public enum Crowds {
        Nobody,
        Some,
        Average,
        Lot,
        Impossible
    }

    public enum Weather {
        Sunny,
        Cloudy,
        Rainy,
        Stromy,
        Foggy,
        Hot,
        Cold,
        Humid
    }

    public class Ride
    {
        public string Name;
        public List<Difficulty> Diff;
        public List<BikeType> Type;
        public List<Crowds> Crowds;
        public List<Weather> Weather;
        public string BestTime;
        public Image Map;

        public Ride()
        {
        }

        public Ride(string name, List<Difficulty> diff, List<BikeType> types, List<Crowds> crowds, List<Weather> weather, string bestTime, Image map) {

            Name = name;
            Diff = diff;
            Type = types;
            Crowds = crowds;
            Weather = weather;
            BestTime = bestTime;
            Map = map;

        }

        // Initalize all ride here



    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            List<Ride> list = new List<Ride>();

            Ride r1 = new Ride() { Name = "Ride 1", Diff = new List<Difficulty> { Difficulty.Easy, Difficulty.Medium }, Type = new List<BikeType> { BikeType.Gravel, BikeType.Mountain }, Crowds = new List<Crowds> { Crowds.Some }, Weather = new List<Weather> { Weather.Sunny }, BestTime = "10AM to 8PM", Map = new Image() };

            list.Add(r1);
        }

        private void DiffBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

 
    }

}

