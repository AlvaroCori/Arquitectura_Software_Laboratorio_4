using System;

namespace CelestialBodiesFlyweight.Classes
{
    public class SpaceMap
    {
        private int _size;
        private int _maxSize;
        private CelestialBody[] _celestialBodies;
        private CelestialBodiesFactory _factory;
        public SpaceMap(int elements, CelestialBodiesFactory factory)
        {
            _factory = factory;
            _celestialBodies = new CelestialBody[elements];
            _size = 0;
            _maxSize = elements;
        }
        private bool InsertCelestialBody(string name, double coordenateX, double coordenateY,double coordenateZ,ICelestialBodyType typeBody)
        {
            if (_size<_maxSize)
            {
                _celestialBodies[_size] = new CelestialBody(typeBody,name, coordenateX, coordenateY, coordenateZ);
                _size = _size + 1;
                return true;
            }
            return false;
        }
        public bool InsertANewCelestialBody(string name, double coordenateX, double coordenateY, double coordenateZ,string typeCelestialBody, string[] colors)
        {
            ICelestialBodyType typeBody = _factory.GetCelestialBodyType(typeCelestialBody, colors);
            return InsertCelestialBody(name, coordenateX, coordenateY, coordenateZ, typeBody);
        }
        public string GetInformationMap()
        {
            string information = "";
            string celestialBodyInfo = "";
            for (int index = 0 ; index < _size ; index = index + 1)
            {
                celestialBodyInfo = _celestialBodies[index].GetInfo();
                information = $"{information}\n----------\n{celestialBodyInfo}"; 
            }
            return information;
        }
        public string CompareTwoElements(string name, string name2)
        {
            CelestialBody celestialBody1 = null;
            CelestialBody celestialBody2 = null;
            if (name == name2)
                return "Es el mismo cuerpo celeste.";
            for (int index = 0 ; index < _size ; index = index + 1)
            {
                if (_celestialBodies[index].Name == name)
                {
                    celestialBody1 = _celestialBodies[index];
                }
                if (_celestialBodies[index].Name == name2)
                {
                    celestialBody2 = _celestialBodies[index];
                }
            }
            if (celestialBody1.CompareType(celestialBody2))
                return "Son del mismo tipo.";
            else
                return "Son de diferente tipo.";
        }
    }
}
