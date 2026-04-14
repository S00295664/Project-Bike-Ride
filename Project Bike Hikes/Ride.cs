using System.Collections.Generic;
using System.Data.Entity;

namespace Project_Bike_Hikes
{


    public enum Difficulty
    {
        Easy = 1,
        Low = 2,
        Medium = 3,
        Hard = 4,
        Impossible = 5
    }
    public enum BikeType
    {
        Road = 1,
        Mountain = 2,
        Hybrid = 3,
        Gravel = 4,
        Electric = 5,
        BMX = 6
    }

    public enum Crowds
    {
        Nobody = 1,
        Few = 2,
        Some = 3,
        Average = 4,
        Many = 5,
        Impossible = 6
    }

    public enum Weather
    {
        Sunny = 1,
        Cloudy = 2,
        Rainy = 3,
        Stromy = 4,
        Foggy = 5,
        Hot = 6,
        Cold = 7,
        Windy = 8,
        Humid = 9
    }

    public enum Country { 
        France = 1,
        Ireland = 2,
        Germany = 3,
        Italy = 4,
        Spain = 6
    }

    public class Ride
    {

        public string Name;
        public Country Country;
        public List<Difficulty> Diff;
        public List<BikeType> Type;
        public List<Crowds> Crowds;
        public List<Weather> Weather;
        public string BestTime;
        public string Map;
        public int Score;
        public List<string> City;
        public int Size;
        

        public Ride() { }
        
        public Ride(string name, List<Difficulty> diff,Country country, List<BikeType> types, List<Crowds> crowds, List<Weather> weather, string bestTime, string map, int score, List<string> city, int size)
        {

            Name = name;
            Country = country;
            Diff = diff;
            Type = types;
            Crowds = crowds;
            Weather = weather;
            BestTime = bestTime;
            Map = map;
            Score = score;
            City = city;
            Size = size;
        }


    }

    public class RideData : DbContext {

        public RideData() : base("RIdeData") { }
        
        public DbSet<Ride> Rides { get; set; }
    }
}
