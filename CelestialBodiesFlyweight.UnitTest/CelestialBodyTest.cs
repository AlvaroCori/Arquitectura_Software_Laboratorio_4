using Microsoft.VisualStudio.TestTools.UnitTesting;
using CelestialBodiesFlyweight.Classes;
namespace CelestialBodiesFlyweight.UnitTest
{
    [TestClass]
    public class CelestialBodyTest
    {
        /*
        Este test comprueba la informacion de un cuerpo celestial con su nombre y coordenadas en unidades astronomicas (UA)
        tambien se agrega la informacion del tipo que compone intrisicamente al cuerpo celestial.
        */
        [TestMethod]
        public void TestCelestialBodyTest1()
        {
            string[] colors= {"#0000ff","#ff0000","#00ff00"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("planeta enano",colors);
            CelestialBody celestialBody = new CelestialBody(celestialBodyType,"TY-8",2.4,4.5);
            string request = celestialBody.GetInfo();
            string typeInfo = "objeto: planeta enano\ncolores: #0000ff #ff0000 #00ff00 ";
            Assert.AreEqual(request, "nombre: TY-8\ncoordenadas: (2.4 UA , 4.5 UA)\n"+typeInfo);
        }
        /*
        Este test comparara el tipo del cuerpo celestial de un celestial body y de uno por referencia
        para demostrar que apunta al mismo tipo cuerpo celestial.
        */
        [TestMethod]
        public void TestCelestialBodyTest2()
        {
            string[] colors= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            CelestialBody celestialBody = new CelestialBody(celestialBodyType,"TY-8",2.4,4.5);
            ICelestialBodyType celestialBodyTypeReference = celestialBodyType;
            bool request = celestialBody.CompareType(celestialBodyTypeReference);
            Assert.IsTrue(request);
        }
        /*
        Este test comparara 2 objetos celestiales que poseen el mismo tipo de cuerpo celestial.
        */
        [TestMethod]
        public void TestCelestialBodyTest3()
        {
            string[] colors= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            ICelestialBodyType celestialBodyType = new CelestialBodyType("estrella amarilla",colors);
            CelestialBody celestialBody1 = new CelestialBody(celestialBodyType,"TY-8",2.4,4.5);
            CelestialBody celestialBody2 = new CelestialBody(celestialBodyType,"TY-9",3.4,4.5);
            bool request = celestialBody1.CompareType(celestialBody2);
            Assert.IsTrue(request);
        }
        /*
        Este test comparara 2 objetos celestiales que poseen diferente tipo de cuerpo celestial.
        */
        [TestMethod]
        public void TestCelestialBodyTest4()
        {
            string[] colors1= {"fff00","#ffff56","#ffff81","#ff9800","#ffc3440","#ffc340"};
            string[] colors2= {"fff00","#ffff56"};
            ICelestialBodyType celestialBodyType1 = new CelestialBodyType("estrella amarilla",colors1);
            ICelestialBodyType celestialBodyType2 = new CelestialBodyType("estrella enana",colors2);
            CelestialBody celestialBody1 = new CelestialBody(celestialBodyType1,"TY-8",2.4,4.5);
            CelestialBody celestialBody2 = new CelestialBody(celestialBodyType2,"TY-9",3.4,4.5);
            bool request = celestialBody1.CompareType(celestialBody2);
            Assert.IsFalse(request);
        }
    }
}
