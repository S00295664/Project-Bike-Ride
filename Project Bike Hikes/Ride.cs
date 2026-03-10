using System.Collections.Generic;
using System.Windows.Controls;

namespace Project_Bike_Hikes
{


    public enum Difficulty
    {
        Easy,
        Low,
        Medium,
        Hard,
        Impossible
    }
    public enum BikeType
    {
        Road,
        Mountain,
        Hybrid,
        Gravel,
        Electric,
        BMX
    }

    public enum Crowds
    {
        Nobody,
        Some,
        Average,
        Lot,
        Impossible
    }

    public enum Weather
    {
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
        public int Score;

        public Ride()
        {
        }

        public Ride(string name, List<Difficulty> diff, List<BikeType> types, List<Crowds> crowds, List<Weather> weather, string bestTime, Image map, int score)
        {

            Name = name;
            Diff = diff;
            Type = types;
            Crowds = crowds;
            Weather = weather;
            BestTime = bestTime;
            Map = map;
            Score = score;

        }
    }
}
