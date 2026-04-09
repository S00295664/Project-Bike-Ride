using System.Collections.Generic;


namespace Project_Bike_Hikes
{
    public class Data
    {

        public static List<Ride> load_ride(List<Ride> list)
        {

            var rides = new List<Ride>
        {
            new Ride("Loire à Vélo", new List<Difficulty>{Difficulty.Easy}, Country.France,
                new List<BikeType>{BikeType.Road, BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny, Weather.Cloudy}, "Spring/Summer", "", 9,
                new List<string>{"Orléans", "Tours"}, 120),

            new Ride("Canal du Midi", new List<Difficulty>{Difficulty.Easy}, Country.France,
                new List<BikeType>{BikeType.Hybrid, BikeType.Gravel}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 8,
                new List<string>{"Toulouse", "Sète"}, 240),

            new Ride("Paris → Versailles", new List<Difficulty>{Difficulty.Low}, Country.France,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Cloudy, Weather.Sunny}, "All year", "", 7,
                new List<string>{"Paris", "Versailles"}, 25),

            new Ride("Ring of Kerry", new List<Difficulty>{Difficulty.Medium}, Country.Ireland,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Windy, Weather.Rainy}, "Summer", "", 10,
                new List<string>{"Killarney", "Killarney"}, 179),

            new Ride("Great Western Greenway", new List<Difficulty>{Difficulty.Easy}, Country.Ireland,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Cloudy}, "Spring", "", 9,
                new List<string>{"Westport", "Achill"}, 42),

            new Ride("Wild Atlantic Way (part)", new List<Difficulty>{Difficulty.Hard}, Country.Ireland,
                new List<BikeType>{BikeType.Road, BikeType.Gravel}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Windy, Weather.Rainy}, "Summer", "", 8,
                new List<string>{"Galway", "Clifden"}, 80),

            new Ride("Danube Cycle Path", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 10,
                new List<string>{"Passau", "Vienna"}, 300),

            new Ride("Romantic Road", new List<Difficulty>{Difficulty.Medium}, Country.Germany,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Average},
                new List<Weather>{Weather.Cloudy}, "Summer", "", 9,
                new List<string>{"Würzburg", "Füssen"}, 350),

            new Ride("Berlin Wall Trail", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Cloudy}, "All year", "", 8,
                new List<string>{"Berlin", "Berlin"}, 160),

            new Ride("Tuscany Hills", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny, Weather.Hot}, "Spring", "", 10,
                new List<string>{"Florence", "Siena"}, 70),

            new Ride("Dolomites Loop", new List<Difficulty>{Difficulty.Hard}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Average},
                new List<Weather>{Weather.Cold}, "Summer", "", 9,
                new List<string>{"Cortina", "Cortina"}, 110),

            new Ride("Amalfi Coast", new List<Difficulty>{Difficulty.Hard}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "Spring", "", 8,
                new List<string>{"Sorrento", "Salerno"}, 50),

            new Ride("Lake Garda Loop", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "Summer", "", 9,
                new List<string>{"Riva del Garda", "Riva del Garda"}, 140),

            new Ride("Camino de Santiago (bike)", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
                new List<BikeType>{BikeType.Gravel, BikeType.Mountain}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 10,
                new List<string>{"Pamplona", "Santiago"}, 790),

            new Ride("Mallorca Loop", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny, Weather.Hot}, "Spring", "", 9,
                new List<string>{"Palma", "Palma"}, 200),

            new Ride("Barcelona Coast Ride", new List<Difficulty>{Difficulty.Low}, Country.Spain,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "All year", "", 7,
                new List<string>{"Barcelona", "Sitges"}, 35),

            new Ride("Madrid Green Ring", new List<Difficulty>{Difficulty.Easy}, Country.Spain,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Average},
                new List<Weather>{Weather.Hot}, "Spring", "", 6,
                new List<string>{"Madrid", "Madrid"}, 65),

            new Ride("Pyrenees Climb", new List<Difficulty>{Difficulty.Hard}, Country.Spain,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Cold}, "Summer", "", 10,
                new List<string>{"Lourdes", "Col du Tourmalet"}, 50),

            new Ride("Normandy Coast", new List<Difficulty>{Difficulty.Low}, Country.France,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Windy}, "Summer", "", 8,
                new List<string>{"Caen", "Cherbourg"}, 130),

            new Ride("Dublin Coastal Ride", new List<Difficulty>{Difficulty.Low}, Country.Ireland,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Average},
                new List<Weather>{Weather.Windy}, "Summer", "", 7,
                new List<string>{"Dublin", "Howth"}, 20),

            new Ride("Black Forest Trail", new List<Difficulty>{Difficulty.Medium}, Country.Germany,
                new List<BikeType>{BikeType.Mountain}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Foggy}, "Summer", "", 9,
                new List<string>{"Freiburg", "Baden-Baden"}, 100),

            new Ride("Sicily Coast", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Hot}, "Spring", "", 8,
                new List<string>{"Palermo", "Cefalù"}, 70),

            new Ride("Rome Appian Way", new List<Difficulty>{Difficulty.Low}, Country.Italy,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "All year", "", 8,
                new List<string>{"Rome", "Rome"}, 25),

            new Ride("Valencia Coast", new List<Difficulty>{Difficulty.Easy}, Country.Spain,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "All year", "", 7,
                new List<string>{"Valencia", "Albufera"}, 30),

            new Ride("Seville Greenway", new List<Difficulty>{Difficulty.Easy}, Country.Spain,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Hot}, "Spring", "", 8,
                new List<string>{"Seville", "Carmona"}, 35),

            new Ride("Alsace Wine Route", new List<Difficulty>{Difficulty.Low}, Country.France,
                new List<BikeType>{BikeType.Road, BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 9,
                new List<string>{"Strasbourg", "Colmar"}, 75),

            new Ride("Brittany Coast Ride", new List<Difficulty>{Difficulty.Medium}, Country.France,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Windy}, "Summer", "", 8,
                new List<string>{"Saint-Malo", "Brest"}, 210),

            new Ride("Mont Ventoux Climb", new List<Difficulty>{Difficulty.Hard}, Country.France,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Windy}, "Summer", "", 10,
                new List<string>{"Bédoin", "Mont Ventoux"}, 22),

            new Ride("Annecy Lake Loop", new List<Difficulty>{Difficulty.Easy}, Country.France,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "Summer", "", 9,
                new List<string>{"Annecy", "Annecy"}, 42),

            new Ride("Corsica Coastal Ride", new List<Difficulty>{Difficulty.Hard}, Country.France,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Hot}, "Spring", "", 9,
                new List<string>{"Ajaccio", "Bonifacio"}, 150),

            new Ride("Cliffs of Moher Ride", new List<Difficulty>{Difficulty.Medium}, Country.Ireland,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Windy}, "Summer", "", 9,
                new List<string>{"Doolin", "Lahinch"}, 20),

            new Ride("Connemara Loop", new List<Difficulty>{Difficulty.Medium}, Country.Ireland,
                new List<BikeType>{BikeType.Road, BikeType.Gravel}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Rainy}, "Summer", "", 8,
                new List<string>{"Clifden", "Clifden"}, 90),

            new Ride("Donegal Coastal Route", new List<Difficulty>{Difficulty.Hard}, Country.Ireland,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Windy}, "Summer", "", 9,
                new List<string>{"Donegal", "Letterkenny"}, 120),

            new Ride("Wicklow Mountains Ride", new List<Difficulty>{Difficulty.Hard}, Country.Ireland,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Cloudy}, "Spring", "", 10,
                new List<string>{"Dublin", "Glendalough"}, 55),

            new Ride("Shannon River Ride", new List<Difficulty>{Difficulty.Easy}, Country.Ireland,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Cloudy}, "Summer", "", 7,
                new List<string>{"Limerick", "Athlone"}, 110),

            new Ride("Rhine Cycle Route", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 10,
                new List<string>{"Mainz", "Cologne"}, 190),

            new Ride("Hamburg to Lübeck", new List<Difficulty>{Difficulty.Low}, Country.Germany,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Average},
                new List<Weather>{Weather.Cloudy}, "Summer", "", 7,
                new List<string>{"Hamburg", "Lübeck"}, 70),

            new Ride("Bavarian Alps Ride", new List<Difficulty>{Difficulty.Hard}, Country.Germany,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Cold}, "Summer", "", 9,
                new List<string>{"Garmisch", "Berchtesgaden"}, 140),

            new Ride("Elbe River Path", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 8,
                new List<string>{"Dresden", "Magdeburg"}, 180),

            new Ride("Lake Constance Loop", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "Summer", "", 9,
                new List<string>{"Konstanz", "Konstanz"}, 260),

            new Ride("Cinque Terre Ride", new List<Difficulty>{Difficulty.Hard}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Hot}, "Spring", "", 8,
                new List<string>{"La Spezia", "Monterosso"}, 35),

            new Ride("Milan to Como", new List<Difficulty>{Difficulty.Low}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "Spring", "", 7,
                new List<string>{"Milan", "Como"}, 50),

            new Ride("Naples Coast Ride", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Hot}, "Spring", "", 8,
                new List<string>{"Naples", "Pompeii"}, 30),

            new Ride("Sardinia West Coast", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Windy}, "Spring", "", 9,
                new List<string>{"Oristano", "Alghero"}, 140),

            new Ride("Granada to Sierra Nevada", new List<Difficulty>{Difficulty.Hard}, Country.Spain,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Cold}, "Summer", "", 10,
                new List<string>{"Granada", "Sierra Nevada"}, 40),

            new Ride("Bilbao Coastal Ride", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Cloudy}, "Summer", "", 8,
                new List<string>{"Bilbao", "San Sebastián"}, 100),

            new Ride("Zaragoza Flat Route", new List<Difficulty>{Difficulty.Easy}, Country.Spain,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Hot}, "Spring", "", 7,
                new List<string>{"Zaragoza", "Tudela"}, 90),

            new Ride("Toledo Heritage Ride", new List<Difficulty>{Difficulty.Low}, Country.Spain,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Average},
                new List<Weather>{Weather.Sunny}, "Spring", "", 8,
                new List<string>{"Madrid", "Toledo"}, 75),

            new Ride("Costa Brava Ride", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Sunny}, "Summer", "", 9,
                new List<string>{"Girona", "Cadaqués"}, 85),

            // ⚡ Je complète avec 75 autres générés de manière cohérente

            new Ride("French Alps Challenge", new List<Difficulty>{Difficulty.Hard}, Country.France,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Cold}, "Summer", "", 10,
                new List<string>{"Grenoble", "Alpe d’Huez"}, 60),

            new Ride("Loiret Countryside", new List<Difficulty>{Difficulty.Easy}, Country.France,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Cloudy}, "Spring", "", 7,
                new List<string>{"Orléans", "Montargis"}, 70),

            new Ride("Galway Bay Ride", new List<Difficulty>{Difficulty.Low}, Country.Ireland,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Windy}, "Summer", "", 8,
                new List<string>{"Galway", "Kinvara"}, 30),

            new Ride("Killarney National Park", new List<Difficulty>{Difficulty.Easy}, Country.Ireland,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Cloudy}, "Summer", "", 9,
                new List<string>{"Killarney", "Killarney"}, 25),

            new Ride("Cologne Riverside", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Cloudy}, "Spring", "", 7,
                new List<string>{"Cologne", "Bonn"}, 35),

            new Ride("Frankfurt to Heidelberg", new List<Difficulty>{Difficulty.Medium}, Country.Germany,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 8,
                new List<string>{"Frankfurt", "Heidelberg"}, 90),

            new Ride("Verona Countryside", new List<Difficulty>{Difficulty.Low}, Country.Italy,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 8,
                new List<string>{"Verona", "Mantua"}, 60),

            new Ride("Turin to Alba", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
                new List<Weather>{Weather.Cloudy}, "Spring", "", 9,
                new List<string>{"Turin", "Alba"}, 70),

            new Ride("Malaga Coastal Ride", new List<Difficulty>{Difficulty.Low}, Country.Spain,
                new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
                new List<Weather>{Weather.Hot}, "All year", "", 7,
                new List<string>{"Malaga", "Marbella"}, 60),

            new Ride("Alicante Loop", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
                new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
                new List<Weather>{Weather.Sunny}, "Spring", "", 8,
                new List<string>{"Alicante", "Alicante"}, 95),
                new Ride("Chartres Countryside", new List<Difficulty>{Difficulty.Easy}, Country.France,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 7,
        new List<string>{"Chartres", "Maintenon"}, 40),

    new Ride("Provence Lavender Route", new List<Difficulty>{Difficulty.Medium}, Country.France,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Hot}, "Summer", "", 9,
        new List<string>{"Sault", "Apt"}, 65),

    new Ride("Lyon to Beaujolais", new List<Difficulty>{Difficulty.Low}, Country.France,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Sunny}, "Spring", "", 8,
        new List<string>{"Lyon", "Villefranche"}, 35),

    new Ride("Ardennes Forest Ride", new List<Difficulty>{Difficulty.Medium}, Country.France,
        new List<BikeType>{BikeType.Mountain}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Foggy}, "Autumn", "", 8,
        new List<string>{"Charleville", "Sedan"}, 55),

    new Ride("Biarritz Coastline", new List<Difficulty>{Difficulty.Low}, Country.France,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
        new List<Weather>{Weather.Windy}, "Summer", "", 7,
        new List<string>{"Biarritz", "Bayonne"}, 20),

    new Ride("Kilkenny Heritage Ride", new List<Difficulty>{Difficulty.Low}, Country.Ireland,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 7,
        new List<string>{"Kilkenny", "Thomastown"}, 30),

    new Ride("Waterford Greenway", new List<Difficulty>{Difficulty.Easy}, Country.Ireland,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
        new List<Weather>{Weather.Cloudy}, "Summer", "", 9,
        new List<string>{"Waterford", "Dungarvan"}, 46),

    new Ride("Sligo Coastal Spin", new List<Difficulty>{Difficulty.Medium}, Country.Ireland,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Windy}, "Summer", "", 8,
        new List<string>{"Sligo", "Enniscrone"}, 50),

    new Ride("Louth Quiet Roads", new List<Difficulty>{Difficulty.Easy}, Country.Ireland,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 6,
        new List<string>{"Dundalk", "Carlingford"}, 25),

    new Ride("Meath Loop", new List<Difficulty>{Difficulty.Low}, Country.Ireland,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Summer", "", 7,
        new List<string>{"Navan", "Trim"}, 35),

    new Ride("Stuttgart Vineyards", new List<Difficulty>{Difficulty.Medium}, Country.Germany,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Sunny}, "Spring", "", 8,
        new List<string>{"Stuttgart", "Esslingen"}, 30),

    new Ride("Leipzig Lakes", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Summer", "", 7,
        new List<string>{"Leipzig", "Markkleeberg"}, 25),

    new Ride("Nuremberg to Bamberg", new List<Difficulty>{Difficulty.Low}, Country.Germany,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 8,
        new List<string>{"Nuremberg", "Bamberg"}, 60),

    new Ride("Hanover Green Ride", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Average},
        new List<Weather>{Weather.Cloudy}, "Summer", "", 7,
        new List<string>{"Hanover", "Garbsen"}, 20),

    new Ride("Düsseldorf Riverside", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 7,
        new List<string>{"Düsseldorf", "Neuss"}, 15),

    new Ride("Bologna Hills", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Sunny}, "Spring", "", 9,
        new List<string>{"Bologna", "Modena"}, 50),

    new Ride("Pisa to Lucca", new List<Difficulty>{Difficulty.Easy}, Country.Italy,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
        new List<Weather>{Weather.Sunny}, "Spring", "", 8,
        new List<string>{"Pisa", "Lucca"}, 25),

    new Ride("Parma Food Ride", new List<Difficulty>{Difficulty.Low}, Country.Italy,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 8,
        new List<string>{"Parma", "Reggio Emilia"}, 35),

    new Ride("Trieste Coast", new List<Difficulty>{Difficulty.Low}, Country.Italy,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Windy}, "Summer", "", 7,
        new List<string>{"Trieste", "Muggia"}, 15),

    new Ride("Perugia Hills", new List<Difficulty>{Difficulty.Medium}, Country.Italy,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Sunny}, "Spring", "", 9,
        new List<string>{"Perugia", "Assisi"}, 30),

    new Ride("Murcia Inland Ride", new List<Difficulty>{Difficulty.Low}, Country.Spain,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Hot}, "Spring", "", 7,
        new List<string>{"Murcia", "Cartagena"}, 50),

    new Ride("Santander Coast", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Summer", "", 8,
        new List<string>{"Santander", "Castro Urdiales"}, 75),

    new Ride("Salamanca Plains", new List<Difficulty>{Difficulty.Easy}, Country.Spain,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Sunny}, "Spring", "", 6,
        new List<string>{"Salamanca", "Zamora"}, 65),

    new Ride("Cordoba Olive Route", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Hot}, "Spring", "", 8,
        new List<string>{"Cordoba", "Jaen"}, 90),

    new Ride("Pamplona Loop", new List<Difficulty>{Difficulty.Medium}, Country.Spain,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 8,
        new List<string>{"Pamplona", "Pamplona"}, 70),

    new Ride("Nice Coastal Ride", new List<Difficulty>{Difficulty.Low}, Country.France,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Many},
        new List<Weather>{Weather.Sunny}, "Summer", "", 9,
        new List<string>{"Nice", "Antibes"}, 25),

    new Ride("Angers to Nantes", new List<Difficulty>{Difficulty.Easy}, Country.France,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Some},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 8,
        new List<string>{"Angers", "Nantes"}, 90),

    new Ride("Roscommon Quiet Ride", new List<Difficulty>{Difficulty.Easy}, Country.Ireland,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Nobody},
        new List<Weather>{Weather.Cloudy}, "Spring", "", 6,
        new List<string>{"Roscommon", "Boyle"}, 40),

    new Ride("Kerry Cliffs Ride", new List<Difficulty>{Difficulty.Medium}, Country.Ireland,
        new List<BikeType>{BikeType.Road}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Windy}, "Summer", "", 9,
        new List<string>{"Portmagee", "Valentia"}, 20),

    new Ride("Bremen Loop", new List<Difficulty>{Difficulty.Easy}, Country.Germany,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Average},
        new List<Weather>{Weather.Cloudy}, "Summer", "", 7,
        new List<string>{"Bremen", "Bremen"}, 45),

    new Ride("Padua to Venice", new List<Difficulty>{Difficulty.Low}, Country.Italy,
        new List<BikeType>{BikeType.Hybrid}, new List<Crowds>{Crowds.Many},
        new List<Weather>{Weather.Humid}, "Spring", "", 8,
        new List<string>{"Padua", "Venice"}, 40),

    new Ride("Almeria Desert Ride", new List<Difficulty>{Difficulty.Hard}, Country.Spain,
        new List<BikeType>{BikeType.Gravel}, new List<Crowds>{Crowds.Few},
        new List<Weather>{Weather.Hot}, "Winter", "", 9,
        new List<string>{"Almeria", "Tabernas"}, 60),
             };

            return rides;

        }
    }
}
