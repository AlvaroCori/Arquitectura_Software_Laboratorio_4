using Microsoft.VisualStudio.TestTools.UnitTesting;
using CelestialBodiesFlyweight.Classes;
namespace CelestialBodiesFlyweight.UnitTest
{
    [TestClass]
    public class CelestialBodyTypeTest
    {
        [TestMethod]
        public void TestIsAYellowStarType()
        {
            string[] colors= {};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            bool request = celestialBodyType.CompareType("estrella amarilla");
            Assert.IsTrue(request);
        }
        [TestMethod]
        public void TestIsABlueStarType()
        {
            string[] colors= {};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            bool request = celestialBodyType.CompareType("estrella azul");
            Assert.IsFalse(request);
        }
        [TestMethod]
        public void TestCelsetialBodyTypeInformation()
        {
            string[] colors= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            string request = celestialBodyType.GetInfo();
            
            Assert.AreEqual(request,"objeto: estrella amarilla\ncolores: fff00 #ffff56 #ffff81 #ff9800 #ffc3440 #ffc340 ");
        }
    }
}
