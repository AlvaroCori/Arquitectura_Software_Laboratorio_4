using Microsoft.VisualStudio.TestTools.UnitTesting;
using CelestialBodiesFlyweight.Classes;
namespace CelestialBodiesFlyweight.UnitTest
{
    [TestClass]
    public class CelestialBodyFactoryTest
    {
        /*
        Este test comprueba que el nombre del tipo es el mismo que retorna la fabrica.
        */
        [TestMethod]
        public void TestFactoryCelestialBodiesTypeTest1()
        {
            string[] colors= {"ff0000", "0000ff"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            string nameType = "planeta mediano";
            factory.GetCelestialBodyType(nameType, colors);
            ICelestialBodyType celestialBodyType = factory.GetCelestialBodyType("planeta mediano", colors);
            bool request = celestialBodyType.CompareType(nameType);
            Assert.IsTrue(request);
        }
        /*
        Este test comprueba que la fabrica produce un tipo y devuelve el mismo tipo para 2 planetas.
        */
        [TestMethod]
        public void TestFactoryCelestialBodiesTypeTest2()
        {
            string[] colors= {"ff0000", "0000ff"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            string nameType = "planeta mediano";
            factory.GetCelestialBodyType(nameType, colors);
            CelestialBody celestialBody1 = new CelestialBody(factory.GetCelestialBodyType(nameType, colors),"TEG-8",2.4,4.5,10.5);
            CelestialBody celestialBody2 = new CelestialBody(factory.GetCelestialBodyType(nameType, colors),"TEG-9",3.4,4.5,12.2);
            bool request = celestialBody1.CompareType(celestialBody2);
            Assert.IsTrue(request);
        }
        /*
        Este test comprueba que la fabrica produce 2 tipos diferentes y los compara.
        */
        [TestMethod]
        public void TestFactoryCelestialBodiesTypeTest3()
        {
            string[] colors1 = {"ff0000", "0000ff"};
            string[] colors2 = {"ff0000","00ff00" ,"0000ff"};
            CelestialBodiesFactory factory = new CelestialBodiesFactory(new CelestialBodyType[20]);
            string nameType1 = "planeta mediano";
            string nameType2 = "sol enano";
            factory.GetCelestialBodyType(nameType1, colors1);
            factory.GetCelestialBodyType(nameType2, colors2);
            CelestialBody celestialBody1 = new CelestialBody(factory.GetCelestialBodyType(nameType1, colors1),"TEG-8",2.4,4.5,3.2);
            CelestialBody celestialBody2 = new CelestialBody(factory.GetCelestialBodyType(nameType2, colors2),"TEG",1.4,4.3,73.2);
            bool request = celestialBody1.CompareType(celestialBody2);
            Assert.IsFalse(request);
        }
    }
}
