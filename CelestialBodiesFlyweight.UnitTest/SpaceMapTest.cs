using Microsoft.VisualStudio.TestTools.UnitTesting;
using CelestialBodiesFlyweight.Classes;
namespace CelestialBodiesFlyweight.UnitTest
{
    [TestClass]
    public class SpaceMapTest
    {
        /*
        Este test contiene un mapa con 2 estrellas gigantes azules y se comprobara si ambos son del 
        mismo tipo comparando el tipo.
        */
        [TestMethod]
        public void SpaceMapTest1()
        {
            string[] colors= {"0000FF","#4FC3F7", "#0277BD", "#015798" , "#03A9F4"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            SpaceMap map = new SpaceMap(4,factory);

            map.InsertANewCelestialBody("TU1",4.5,4.3,2.3,"estrella gigante azul",colors);
            map.InsertANewCelestialBody("TU2",5.5,8.3,4.4,"estrella gigante azul",colors);
            string request = map.CompareTwoElements("TU1","TU2");
            Assert.AreEqual(request,"Son del mismo tipo.");
        }
        /*
        Este test contiene un mapa con 2 estrellas gigantes azules y se comparara una 
        estrella asi misma.
        */
        [TestMethod]
        public void SpaceMapTest2()
        {
            string[] colors= {"0000FF","#4FC3F7", "#0277BD", "#015798" , "#03A9F4"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            SpaceMap map = new SpaceMap(4,factory);

            map.InsertANewCelestialBody("TU1",4.5,4.3,3.2,"estrella gigante azul",colors);
            map.InsertANewCelestialBody("TU2",5.5,8.3,13.2,"estrella gigante azul",colors);
            string request = map.CompareTwoElements("TU1","TU1");
            Assert.AreEqual(request,"Es el mismo cuerpo celeste.");
        }
        /*
        Este test contiene un mapa con 2 estrellas una gigante azul y una 
        gigante roja se comparara ambas estrellas diferentes.
        */
        [TestMethod]
        public void SpaceMapTest3()
        {
            string[] colors1 = {"0000FF","#4FC3F7", "#0277BD", "#015798" , "#03A9F4"};
            string[] colors2 = {"#FF2834", "#CE2834", "#CE280A", "#AB3B18"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            SpaceMap map = new SpaceMap(4,factory);

            map.InsertANewCelestialBody("TU1",4.5,4.3,35.2,"estrella gigante azul",colors1);
            map.InsertANewCelestialBody("AF4",235.5,18.3,32.2,"estrella gigante roja",colors2);
            string request = map.CompareTwoElements("TU1","AF4");
            Assert.AreEqual(request,"Son de diferente tipo.");
        }
        /*
        Este test contiene un mapa con 3 estrellas 2 gigantes azules y 
        una gigante roja se mostrara la informacion de todo el mapa.
        */
        [TestMethod]
        public void SpaceMapTest4()
        {
            string[] colors1 = {"#0000FF","#4FC3F7", "#0277BD", "#015798" , "#03A9F4"};
            string[] colors2 = {"#FF2834", "#CE2834", "#CE280A", "#AB3B18"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            SpaceMap map = new SpaceMap(4,factory);

            map.InsertANewCelestialBody("TU1",4.5,4.3,31.2,"estrella gigante azul",colors1);
            map.InsertANewCelestialBody("TU2",5.5,8.3,23.2,"estrella gigante azul",colors1);
            map.InsertANewCelestialBody("AF4",235.5,18.3,33.2,"estrella gigante roja",colors2);
            string gigantBlue1 = "nombre: TU1\ncoordenadas: (4.5 UA , 4.3 UA , 31.2 UA)\n";
            string gigantBlue2 = "nombre: TU2\ncoordenadas: (5.5 UA , 8.3 UA , 23.2 UA)\n";
            string gigantRed1 = "nombre: AF4\ncoordenadas: (235.5 UA , 18.3 UA , 33.2 UA)\n";
            string gigantBlueType = "objeto: estrella gigante azul\ncolores: #0000FF #4FC3F7 #0277BD #015798 #03A9F4 ";
            string gigantRedType = "objeto: estrella gigante roja\ncolores: #FF2834 #CE2834 #CE280A #AB3B18 ";
            string separator = "\n----------\n";
            string request = map.GetInformationMap();
            Assert.AreEqual(request ,separator + gigantBlue1 + gigantBlueType + separator + gigantBlue2 + gigantBlueType + separator + gigantRed1 + gigantRedType);
        }
        /*
        Este test contiene un mapa con 4 estrellas 2 gigantes azules y 2 gigantes roja guardados en un mapa de un 
        maximo de 4 cuerpos celestiales y  el resultado es un booleano que afirme que todas las estrellas 
        fueron creadas.
        */
        [TestMethod]
        public void SpaceMapTest5()
        {
            string[] colors1 = {"#0000FF","#4FC3F7", "#0277BD", "#015798" , "#03A9F4"};
            string[] colors2 = {"#FF2834", "#CE2834", "#CE280A", "#AB3B18"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            SpaceMap map = new SpaceMap(4,factory);
            bool request = true;
            request = request && map.InsertANewCelestialBody("TU1",4.5,4.3,31.2,"estrella gigante azul",colors1);
            request = request && map.InsertANewCelestialBody("TU2",5.5,8.3,23.2,"estrella gigante azul",colors1);
            request = request && map.InsertANewCelestialBody("AF4",235.5,18.3,33.2,"estrella gigante roja",colors2);
            request = request && map.InsertANewCelestialBody("AF5",235.5,23.3,63.2,"estrella gigante roja",colors2);
            Assert.IsTrue(request);
        }
        /*
        Este test contiene un mapa con 4 estrellas 2 gigantes azules y 3 gigantes roja guardados en un mapa de un 
        maximo de 4 cuerpos celestiales y  el resultado es un booleano que afirme que no todas las estrellas 
        fueron creadas.
        */
        [TestMethod]
        public void SpaceMapTest6()
        {
            string[] colors1 = {"#0000FF","#4FC3F7", "#0277BD", "#015798" , "#03A9F4"};
            string[] colors2 = {"#FF2834", "#CE2834", "#CE280A", "#AB3B18"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            SpaceMap map = new SpaceMap(4,factory);
            bool request = true;
            request = request && map.InsertANewCelestialBody("TU1",4.5,4.3,31.2,"estrella gigante azul",colors1);
            request = request && map.InsertANewCelestialBody("TU2",5.5,8.3,23.2,"estrella gigante azul",colors1);
            request = request && map.InsertANewCelestialBody("AF4",235.5,18.3,33.2,"estrella gigante roja",colors2);
            request = request && map.InsertANewCelestialBody("AF5",235.5,23.3,63.2,"estrella gigante roja",colors2);
            request = request && map.InsertANewCelestialBody("AF6",25.3,222.4,33.2,"estrella gigante roja",colors2);
            Assert.IsFalse(request);
        }
    }
}
