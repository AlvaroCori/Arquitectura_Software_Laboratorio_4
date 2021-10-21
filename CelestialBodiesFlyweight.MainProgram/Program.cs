using System;
using CelestialBodiesFlyweight.Classes;
namespace CelestialBodiesFlyweight.MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            string[] colors = {"#FFFFFF","#FFFFF9","#FFFBF9","#FAFBF9"};
            var whiteStar = factory.GetCelestialBodyType("estrella blanca",colors);
            string[] colors2 = {"#000000"};
            var blackHole =factory.GetCelestialBodyType("agujero negro enano",colors2);
            string[] colors3 = {" #DC9570", "#5582C8", "#142A46", "#E9D3BF", "#ACA18A", "#344551", "#1E2834"};
            var gigantPlanet =factory.GetCelestialBodyType("planeta gigante",colors3);
            string[] colors4 = {"#FF2834", "#CE2834", "#CE280A", "#AB3B18"};
            var gigantRed  =factory.GetCelestialBodyType("estrella gigante roja",colors4);
            */
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            SpaceMap map = new SpaceMap(10,factory);
            
            string[] colorsStar = {"#FFFFFF","#FFFFF9","#FFFBF9","#FAFBF9"};
            map.InsertANewCelestialBody("AFD",  2.3, 4.5,"estrella enana blanca", colorsStar);
            map.InsertANewCelestialBody("AFF",18.3,7.5,"estrella enana blanca", colorsStar);
            map.InsertANewCelestialBody("AFG",6.3,9.5,"estrella enana blanca", colorsStar);
            map.InsertANewCelestialBody("AFH",3.3,10.5,"estrella enana blanca", colorsStar);
            
            string[] colorsBlackHole = {"#000000"};
            map.InsertANewCelestialBody("S-1",14.3,54.5,"agujero negro", colorsBlackHole);
            
            string[] colorsPlanetGigant = {" #DC9570", "#5582C8", "#142A46", "#E9D3BF", "#ACA18A", "#344551", "#1E2834"};
            map.InsertANewCelestialBody("AFG-1",6.35,9.55,"planeta gigante", colorsPlanetGigant);
            map.InsertANewCelestialBody("AFG-2",6.25,9.45,"planeta gigante", colorsPlanetGigant);

            string[] colorsRedStarGigant = {"#FF2834", "#CE2834", "#CE280A", "#AB3B18"};
            map.InsertANewCelestialBody("AFD2",8.4,15.4,"estrella gigante roja", colorsPlanetGigant);
            Console.WriteLine(map.GetInformationMap());
            Console.WriteLine("\n");
            Console.WriteLine(map.CompareTwoElements("AFG-1","AFG-2"));
        }
    }
}
