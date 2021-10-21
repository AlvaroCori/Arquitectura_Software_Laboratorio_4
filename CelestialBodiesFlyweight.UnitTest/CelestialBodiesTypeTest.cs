using Microsoft.VisualStudio.TestTools.UnitTesting;
using CelestialBodiesFlyweight.Classes;
namespace CelestialBodiesFlyweight.UnitTest
{
    [TestClass]
    public class CelestialBodyTypeTest
    {
        /*
        Este test comprueba que se creo un tipo de cuerpo celestial llamado estrella amarilla
        */
        [TestMethod]
        public void TestCelestialBodyTypeTest1()
        {
            string[] colors= {};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            bool request = celestialBodyType.CompareType("estrella amarilla");
            Assert.IsTrue(request);
        }
        /*
        Este test comprueba que no se creo un tipo de cuerpo celestial llamado estrella azul
        */
        [TestMethod]
        public void TestCelestialBodyTypeTest2()
        {
            string[] colors= {};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            bool request = celestialBodyType.CompareType("estrella azul");
            Assert.IsFalse(request);
        }
        /*
        Este test comprueba toda la informacion que guarda el tipo cuerpo celeste con su nombre y sus colores.
        */
        [TestMethod]
        public void TestCelestialBodyTypeTest3()
        {
            string[] colors= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            string request = celestialBodyType.GetInfo();
            
            Assert.AreEqual(request,"objeto: estrella amarilla\ncolores: fff00 #ffff56 #ffff81 #ff9800 #ffc3440 #ffc340 ");
        }
    }
}
