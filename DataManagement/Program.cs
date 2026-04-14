using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Bike_Hikes;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RideData db = new RideData();

            using (db) {

                Ride r1 = new Ride("Loire à Vélo", new List<Difficulty> { Difficulty.Easy }, Country.France,
                    new List<BikeType> { BikeType.Road, BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny, Weather.Cloudy }, "Spring/Summer", "", 9,
                    new List<string> { "Orléans", "Tours" }, 120);

                Ride r2 = new Ride("Canal du Midi", new List<Difficulty> { Difficulty.Easy }, Country.France,
                    new List<BikeType> { BikeType.Hybrid, BikeType.Gravel }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Toulouse", "Sète" }, 240);

                Ride r3 = new Ride("Paris → Versailles", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Cloudy, Weather.Sunny }, "All year", "", 7,
                    new List<string> { "Paris", "Versailles" }, 25);

                Ride r4 = new Ride("Ring of Kerry", new List<Difficulty> { Difficulty.Medium }, Country.Ireland,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Windy, Weather.Rainy }, "Summer", "", 10,
                    new List<string> { "Killarney", "Killarney" }, 179);

                Ride r5 = new Ride("Great Western Greenway", new List<Difficulty> { Difficulty.Easy }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 9,
                    new List<string> { "Westport", "Achill" }, 42);

                Ride r6 = new Ride("Wild Atlantic Way (part)", new List<Difficulty> { Difficulty.Hard }, Country.Ireland,
                    new List<BikeType> { BikeType.Road, BikeType.Gravel }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Windy, Weather.Rainy }, "Summer", "", 8,
                    new List<string> { "Galway", "Clifden" }, 80);

                Ride r7 = new Ride("Danube Cycle Path", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 10,
                    new List<string> { "Passau", "Vienna" }, 300);

                Ride r8 = new Ride("Romantic Road", new List<Difficulty> { Difficulty.Medium }, Country.Germany,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 9,
                    new List<string> { "Würzburg", "Füssen" }, 350);

                Ride r9 = new Ride("Berlin Wall Trail", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Cloudy }, "All year", "", 8,
                    new List<string> { "Berlin", "Berlin" }, 160);

                Ride r10 = new Ride("Tuscany Hills", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny, Weather.Hot }, "Spring", "", 10,
                    new List<string> { "Florence", "Siena" }, 70);

                Ride r11 = new Ride("Dolomites Loop", new List<Difficulty> { Difficulty.Hard }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Cold }, "Summer", "", 9,
                    new List<string> { "Cortina", "Cortina" }, 110);

                Ride r12 = new Ride("Amalfi Coast", new List<Difficulty> { Difficulty.Hard }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Sorrento", "Salerno" }, 50);

                Ride r13 = new Ride("Lake Garda Loop", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Summer", "", 9,
                    new List<string> { "Riva del Garda", "Riva del Garda" }, 140);

                Ride r14 = new Ride("Camino de Santiago (bike)", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Gravel, BikeType.Mountain }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 10,
                    new List<string> { "Pamplona", "Santiago" }, 790);

                Ride r15 = new Ride("Mallorca Loop", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny, Weather.Hot }, "Spring", "", 9,
                    new List<string> { "Palma", "Palma" }, 200);

                Ride r16 = new Ride("Barcelona Coast Ride", new List<Difficulty> { Difficulty.Low }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "All year", "", 7,
                    new List<string> { "Barcelona", "Sitges" }, 35);

                Ride r17 = new Ride("Madrid Green Ring", new List<Difficulty> { Difficulty.Easy }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Hot }, "Spring", "", 6,
                    new List<string> { "Madrid", "Madrid" }, 65);

                Ride r18 = new Ride("Pyrenees Climb", new List<Difficulty> { Difficulty.Hard }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cold }, "Summer", "", 10,
                    new List<string> { "Lourdes", "Col du Tourmalet" }, 50);

                Ride r19 = new Ride("Normandy Coast", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Windy }, "Summer", "", 8,
                    new List<string> { "Caen", "Cherbourg" }, 130);

                Ride r20 = new Ride("Dublin Coastal Ride", new List<Difficulty> { Difficulty.Low }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Windy }, "Summer", "", 7,
                    new List<string> { "Dublin", "Howth" }, 20);


                Ride r21 = new Ride("Black Forest Trail", new List<Difficulty> { Difficulty.Medium }, Country.Germany,
                    new List<BikeType> { BikeType.Mountain }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Foggy }, "Summer", "", 9,
                    new List<string> { "Freiburg", "Baden-Baden" }, 100);

                Ride r22 = new Ride("Sicily Coast", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Hot }, "Spring", "", 8,
                    new List<string> { "Palermo", "Cefalù" }, 70);

                Ride r23 = new Ride("Rome Appian Way", new List<Difficulty> { Difficulty.Low }, Country.Italy,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "All year", "", 8,
                    new List<string> { "Rome", "Rome" }, 25);

                Ride r24 = new Ride("Valencia Coast", new List<Difficulty> { Difficulty.Easy }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "All year", "", 7,
                    new List<string> { "Valencia", "Albufera" }, 30);

                Ride r25 = new Ride("Seville Greenway", new List<Difficulty> { Difficulty.Easy }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Hot }, "Spring", "", 8,
                    new List<string> { "Seville", "Carmona" }, 35);

                Ride r26 = new Ride("Alsace Wine Route", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Road, BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 9,
                    new List<string> { "Strasbourg", "Colmar" }, 75);

                Ride r27 = new Ride("Brittany Coast Ride", new List<Difficulty> { Difficulty.Medium }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Windy }, "Summer", "", 8,
                    new List<string> { "Saint-Malo", "Brest" }, 210);

                Ride r28 = new Ride("Mont Ventoux Climb", new List<Difficulty> { Difficulty.Hard }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Windy }, "Summer", "", 10,
                    new List<string> { "Bédoin", "Mont Ventoux" }, 22);

                Ride r29 = new Ride("Annecy Lake Loop", new List<Difficulty> { Difficulty.Easy }, Country.France,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Summer", "", 9,
                    new List<string> { "Annecy", "Annecy" }, 42);

                Ride r30 = new Ride("Corsica Coastal Ride", new List<Difficulty> { Difficulty.Hard }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Hot }, "Spring", "", 9,
                    new List<string> { "Ajaccio", "Bonifacio" }, 150);

                Ride r31 = new Ride("Cliffs of Moher Ride", new List<Difficulty> { Difficulty.Medium }, Country.Ireland,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Windy }, "Summer", "", 9,
                    new List<string> { "Doolin", "Lahinch" }, 20);

                Ride r32 = new Ride("Connemara Loop", new List<Difficulty> { Difficulty.Medium }, Country.Ireland,
                    new List<BikeType> { BikeType.Road, BikeType.Gravel }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Rainy }, "Summer", "", 8,
                    new List<string> { "Clifden", "Clifden" }, 90);

                Ride r33 = new Ride("Donegal Coastal Route", new List<Difficulty> { Difficulty.Hard }, Country.Ireland,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Windy }, "Summer", "", 9,
                    new List<string> { "Donegal", "Letterkenny" }, 120);

                Ride r34 = new Ride("Wicklow Mountains Ride", new List<Difficulty> { Difficulty.Hard }, Country.Ireland,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 10,
                    new List<string> { "Dublin", "Glendalough" }, 55);

                Ride r35 = new Ride("Shannon River Ride", new List<Difficulty> { Difficulty.Easy }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 7,
                    new List<string> { "Limerick", "Athlone" }, 110);

                Ride r36 = new Ride("Rhine Cycle Route", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 10,
                    new List<string> { "Mainz", "Cologne" }, 190);

                Ride r37 = new Ride("Hamburg to Lübeck", new List<Difficulty> { Difficulty.Low }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 7,
                    new List<string> { "Hamburg", "Lübeck" }, 70);

                Ride r38 = new Ride("Bavarian Alps Ride", new List<Difficulty> { Difficulty.Hard }, Country.Germany,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cold }, "Summer", "", 9,
                    new List<string> { "Garmisch", "Berchtesgaden" }, 140);

                Ride r39 = new Ride("Elbe River Path", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Dresden", "Magdeburg" }, 180);

                Ride r40 = new Ride("Lake Constance Loop", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Summer", "", 9,
                    new List<string> { "Konstanz", "Konstanz" }, 260);

                Ride r41 = new Ride("Cinque Terre Ride", new List<Difficulty> { Difficulty.Hard }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Hot }, "Spring", "", 8,
                    new List<string> { "La Spezia", "Monterosso" }, 35);

                Ride r42 = new Ride("Milan to Como", new List<Difficulty> { Difficulty.Low }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 7,
                    new List<string> { "Milan", "Como" }, 50);

                Ride r43 = new Ride("Naples Coast Ride", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Hot }, "Spring", "", 8,
                    new List<string> { "Naples", "Pompeii" }, 30);

                Ride r44 = new Ride("Sardinia West Coast", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Windy }, "Spring", "", 9,
                    new List<string> { "Oristano", "Alghero" }, 140);

                Ride r45 = new Ride("Granada to Sierra Nevada", new List<Difficulty> { Difficulty.Hard }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cold }, "Summer", "", 10,
                    new List<string> { "Granada", "Sierra Nevada" }, 40);

                Ride r46 = new Ride("Bilbao Coastal Ride", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 8,
                    new List<string> { "Bilbao", "San Sebastián" }, 100);

                Ride r47 = new Ride("Zaragoza Flat Route", new List<Difficulty> { Difficulty.Easy }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Hot }, "Spring", "", 7,
                    new List<string> { "Zaragoza", "Tudela" }, 90);

                Ride r48 = new Ride("Toledo Heritage Ride", new List<Difficulty> { Difficulty.Low }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Madrid", "Toledo" }, 75);

                Ride r49 = new Ride("Costa Brava Ride", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Summer", "", 9,
                    new List<string> { "Girona", "Cadaqués" }, 85);

                Ride r50 = new Ride("French Alps Challenge", new List<Difficulty> { Difficulty.Hard }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cold }, "Summer", "", 10,
                    new List<string> { "Grenoble", "Alpe d’Huez" }, 60);

                Ride r51 = new Ride("Loiret Countryside", new List<Difficulty> { Difficulty.Easy }, Country.France,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 7,
                    new List<string> { "Orléans", "Montargis" }, 70);

                Ride r52 = new Ride("Galway Bay Ride", new List<Difficulty> { Difficulty.Low }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Windy }, "Summer", "", 8,
                    new List<string> { "Galway", "Kinvara" }, 30);

                Ride r53 = new Ride("Killarney National Park", new List<Difficulty> { Difficulty.Easy }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 9,
                    new List<string> { "Killarney", "Killarney" }, 25);

                Ride r54 = new Ride("Cologne Riverside", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 7,
                    new List<string> { "Cologne", "Bonn" }, 35);

                Ride r55 = new Ride("Frankfurt to Heidelberg", new List<Difficulty> { Difficulty.Medium }, Country.Germany,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Frankfurt", "Heidelberg" }, 90);

                Ride r56 = new Ride("Verona Countryside", new List<Difficulty> { Difficulty.Low }, Country.Italy,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Verona", "Mantua" }, 60);

                Ride r57 = new Ride("Turin to Alba", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 9,
                    new List<string> { "Turin", "Alba" }, 70);

                Ride r58 = new Ride("Malaga Coastal Ride", new List<Difficulty> { Difficulty.Low }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Hot }, "All year", "", 7,
                    new List<string> { "Malaga", "Marbella" }, 60);

                Ride r59 = new Ride("Alicante Loop", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Alicante", "Alicante" }, 95);

                Ride r60 = new Ride("Chartres Countryside", new List<Difficulty> { Difficulty.Easy }, Country.France,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 7,
                    new List<string> { "Chartres", "Maintenon" }, 40);

                Ride r61 = new Ride("Provence Lavender Route", new List<Difficulty> { Difficulty.Medium }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Hot }, "Summer", "", 9,
                    new List<string> { "Sault", "Apt" }, 65);

                Ride r62 = new Ride("Lyon to Beaujolais", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Lyon", "Villefranche" }, 35);

                Ride r63 = new Ride("Ardennes Forest Ride", new List<Difficulty> { Difficulty.Medium }, Country.France,
                    new List<BikeType> { BikeType.Mountain }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Foggy }, "Autumn", "", 8,
                    new List<string> { "Charleville", "Sedan" }, 55);

                Ride r64 = new Ride("Biarritz Coastline", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Windy }, "Summer", "", 7,
                    new List<string> { "Biarritz", "Bayonne" }, 20);

                Ride r65 = new Ride("Kilkenny Heritage Ride", new List<Difficulty> { Difficulty.Low }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 7,
                    new List<string> { "Kilkenny", "Thomastown" }, 30);

                Ride r66 = new Ride("Waterford Greenway", new List<Difficulty> { Difficulty.Easy }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 9,
                    new List<string> { "Waterford", "Dungarvan" }, 46);

                Ride r67 = new Ride("Sligo Coastal Spin", new List<Difficulty> { Difficulty.Medium }, Country.Ireland,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Windy }, "Summer", "", 8,
                    new List<string> { "Sligo", "Enniscrone" }, 50);

                Ride r68 = new Ride("Louth Quiet Roads", new List<Difficulty> { Difficulty.Easy }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 6,
                    new List<string> { "Dundalk", "Carlingford" }, 25);

                Ride r69 = new Ride("Meath Loop", new List<Difficulty> { Difficulty.Low }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 7,
                    new List<string> { "Navan", "Trim" }, 35);

                Ride r70 = new Ride("Stuttgart Vineyards", new List<Difficulty> { Difficulty.Medium }, Country.Germany,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Stuttgart", "Esslingen" }, 30);

                Ride r71 = new Ride("Leipzig Lakes", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 6,
                    new List<string> { "Leipzig", "Markkleeberg" }, 25);

                Ride r72 = new Ride("Nuremberg to Bamberg", new List<Difficulty> { Difficulty.Low }, Country.Germany,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 7,
                    new List<string> { "Nuremberg", "Bamberg" }, 60);

                Ride r73 = new Ride("Hanover Green Ride", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 7,
                    new List<string> { "Hanover", "Garbsen" }, 20);

                Ride r74 = new Ride("Düsseldorf Riverside", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 7,
                    new List<string> { "Düsseldorf", "Neuss" }, 15);

                Ride r75 = new Ride("Bologna Hills", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 9,
                    new List<string> { "Bologna", "Modena" }, 50);

                Ride r76 = new Ride("Pisa to Lucca", new List<Difficulty> { Difficulty.Easy }, Country.Italy,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Pisa", "Lucca" }, 25);

                Ride r77 = new Ride("Parma Food Ride", new List<Difficulty> { Difficulty.Low }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 8,
                    new List<string> { "Parma", "Reggio Emilia" }, 35);

                Ride r78 = new Ride("Trieste Coast", new List<Difficulty> { Difficulty.Low }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Windy }, "Summer", "", 7,
                    new List<string> { "Trieste", "Muggia" }, 15);

                Ride r79 = new Ride("Perugia Hills", new List<Difficulty> { Difficulty.Medium }, Country.Italy,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 9,
                    new List<string> { "Perugia", "Assisi" }, 30);

                Ride r80 = new Ride("Murcia Inland Ride", new List<Difficulty> { Difficulty.Low }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Hot }, "Spring", "", 7,
                    new List<string> { "Murcia", "Cartagena" }, 50);

                Ride r81 = new Ride("Santander Coast", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 8,
                    new List<string> { "Santander", "Castro Urdiales" }, 75);

                Ride r82 = new Ride("Salamanca Plains", new List<Difficulty> { Difficulty.Easy }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 6,
                    new List<string> { "Salamanca", "Zamora" }, 65);

                Ride r83 = new Ride("Cordoba Olive Route", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Hot }, "Spring", "", 8,
                    new List<string> { "Cordoba", "Jaen" }, 90);

                Ride r84 = new Ride("Pamplona Loop", new List<Difficulty> { Difficulty.Medium }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 8,
                    new List<string> { "Pamplona", "Pamplona" }, 70);

                Ride r85 = new Ride("Nice Coastal Ride", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Summer", "", 9,
                    new List<string> { "Nice", "Antibes" }, 25);

                Ride r86 = new Ride("Angers to Nantes", new List<Difficulty> { Difficulty.Easy }, Country.France,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 8,
                    new List<string> { "Angers", "Nantes" }, 90);

                Ride r87 = new Ride("Roscommon Quiet Ride", new List<Difficulty> { Difficulty.Easy }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Nobody },
                    new List<Weather> { Weather.Cloudy }, "Spring", "", 6,
                    new List<string> { "Roscommon", "Boyle" }, 40);

                Ride r88 = new Ride("Kerry Cliffs Ride", new List<Difficulty> { Difficulty.Medium }, Country.Ireland,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Windy }, "Summer", "", 9,
                    new List<string> { "Portmagee", "Valentia" }, 20);

                Ride r89 = new Ride("Bremen Loop", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Average },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 7,
                    new List<string> { "Bremen", "Bremen" }, 45);

                Ride r90 = new Ride("Padua to Venice", new List<Difficulty> { Difficulty.Low }, Country.Italy,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Humid }, "Spring", "", 8,
                    new List<string> { "Padua", "Venice" }, 40);

                Ride r91 = new Ride("Almeria Desert Ride", new List<Difficulty> { Difficulty.Hard }, Country.Spain,
                    new List<BikeType> { BikeType.Gravel }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Hot }, "Winter", "", 9,
                    new List<string> { "Almeria", "Tabernas" }, 60);

                Ride r92 = new Ride("Nice to Monaco", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 8,
                    new List<string> { "Nice", "Monaco" }, 25);

                Ride r93 = new Ride("Cork Coastal Ride", new List<Difficulty> { Difficulty.Medium }, Country.Ireland,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Windy }, "Summer", "", 8,
                    new List<string> { "Cork", "Kinsale" }, 30);

                Ride r94 = new Ride("Munich City Loop", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Cloudy }, "All year", "", 7,
                    new List<string> { "Munich", "Munich" }, 35);

                Ride r95 = new Ride("Venice Lagoon Ride", new List<Difficulty> { Difficulty.Easy }, Country.Italy,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Humid }, "Spring", "", 7,
                    new List<string> { "Venice", "Chioggia" }, 40);

                Ride r96 = new Ride("Seville Riverside", new List<Difficulty> { Difficulty.Easy }, Country.Spain,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Hot }, "Spring", "", 7,
                    new List<string> { "Seville", "Dos Hermanas" }, 20);

                Ride r97 = new Ride("Bordeaux Vineyard Ride", new List<Difficulty> { Difficulty.Low }, Country.France,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Sunny }, "Spring", "", 9,
                    new List<string> { "Bordeaux", "Saint-Émilion" }, 45);

                Ride r98 = new Ride("Limerick Greenway", new List<Difficulty> { Difficulty.Easy }, Country.Ireland,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Few },
                    new List<Weather> { Weather.Cloudy }, "Summer", "", 7,
                    new List<string> { "Limerick", "Listowel" }, 40);

                Ride r99 = new Ride("Hamburg Harbor Ride", new List<Difficulty> { Difficulty.Easy }, Country.Germany,
                    new List<BikeType> { BikeType.Hybrid }, new List<Crowds> { Crowds.Many },
                    new List<Weather> { Weather.Windy }, "Spring", "", 7,
                    new List<string> { "Hamburg", "Blankenese" }, 25);

                Ride r100 = new Ride("Gran Canaria Loop", new List<Difficulty> { Difficulty.Hard }, Country.Spain,
                    new List<BikeType> { BikeType.Road }, new List<Crowds> { Crowds.Some },
                    new List<Weather> { Weather.Hot }, "Winter", "", 10,
                    new List<string> { "Las Palmas", "Las Palmas" }, 180);

                List<Ride> rides = new List<Ride>
                {
                    r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                    r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                    r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                    r31, r32, r33, r34, r35, r36, r37, r38, r39, r40,
                    r41, r42, r43, r44, r45, r46, r47, r48, r49, r50,
                    r51, r52, r53, r54, r55, r56, r57, r58, r59, r60,
                    r61, r62, r63, r64, r65, r66, r67, r68, r69, r70,
                    r71, r72, r73, r74, r75, r76, r77, r78, r79, r80,
                    r81, r82, r83, r84, r85, r86, r87, r88, r89, r90,
                    r91, r92, r93, r94, r95, r96, r97, r98, r99, r100
                };

                if (!db.Rides.Any())
                {
                    db.Rides.AddRange(rides);
                    db.SaveChanges();
                }

            }
        }
    }
}
