using Microsoft.VisualStudio.TestTools.UnitTesting;
using CelestialBodiesFlyweight.Classes;
namespace CelestialBodiesFlyweight.UnitTest
{
    [TestClass]
    public class CelestialBodyTest
    {
        [TestMethod]
        public void TestCelestialBodyInformation()
        {
            string[] colors= {"#0000ff","#ff0000","#00ff00"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("planeta enano",colors);
            CelestialBody celestialBody = new CelestialBody(celestialBodyType,"TY-8",2.4,4.5,91.2);
            string request = celestialBody.GetInfo();
            string typeInfo = "objeto: planeta enano\ncolores: #0000ff #ff0000 #00ff00 ";
            Assert.AreEqual(request, "nombre: TY-8\ncoordenadas: (2.4 UA , 4.5 UA , 91.2 UA)\n"+typeInfo);
        }
        [TestMethod]
        public void TestCompareCelestialBodyTypeOfACelestialBody()
        {
            string[] colors= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            CelestialBody celestialBody = new CelestialBody(celestialBodyType,"TY-8",2.4,4.5,45.2);
            ICelestialBodyType celestialBodyTypeReference = celestialBodyType;
            bool request = celestialBody.CompareType(celestialBodyTypeReference);
            Assert.IsTrue(request);
        }
        [TestMethod]
        public void TestCompareTheSameTipeForTwoCelestialBodies()
        {
            string[] colors= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            CelestialBody celestialBody1 = new CelestialBody(celestialBodyType,"TY-8",2.4,4.5,53.3);
            CelestialBody celestialBody2 = new CelestialBody(celestialBodyType,"TY-9",3.4,4.5,113.2);
            bool request = celestialBody1.CompareType(celestialBody2);
            Assert.IsTrue(request);
        }
        [TestMethod]
        public void TestCompareDifferentsTipesForTwoCelestialBodies()
        {
            string[] colors1= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            string[] colors2= {"fff00","#ffff56"};
            ICelestialBodyType celestialBodyType1 = new CelestialBodyType("estrella amarilla",colors1);
            ICelestialBodyType celestialBodyType2 = new CelestialBodyType("estrella enana",colors2);
            CelestialBody celestialBody1 = new CelestialBody(celestialBodyType1,"TY-8",2.4,4.5,49.1);
            CelestialBody celestialBody2 = new CelestialBody(celestialBodyType2,"TY-9",3.4,4.5,23.2);
            bool request = celestialBody1.CompareType(celestialBody2);
            Assert.IsFalse(request);
        }
    }
}
