using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private static int idCount = 0;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public List<Difficulty> Diff { get; set; }
        public List<BikeType> Type { get; set; }
        public List<Crowds> Crowds { get; set; }
        public List<Weather> Weather { get; set; }
        public string BestTime { get; set; }
        public string Map { get; set; }
        public int Score { get; set; }
        public List<string> City { get; set; }
        public int Size { get; set; }

        public Ride(string name, List<Difficulty> diff,Country country, List<BikeType> types, List<Crowds> crowds, List<Weather> weather, string bestTime, string map, int score, List<string> city, int size)
        {
            Id = idCount++;
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
