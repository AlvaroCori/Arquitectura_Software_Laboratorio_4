using System;

namespace CelestialBodiesFlyweight.Classes
{
    public class CelestialBody
    {
        private ICelestialBodyType _type;
        private string _name;
        private double _x;
        private double _y;
        public string Name {
            get{ return _name;}
        }
        public CelestialBody(ICelestialBodyType myType, string name, double x, double y)
        {
            _type = myType;
            _name = name;
            _x = x;
            _y = y;
        }
        public string GetInfo()
        {
            return $"Nombre:{_name}\nCoordenadas:({_x} UA , {_y} UA)\n{_type.GetInfo()}";
        }
        public bool CompareType(ICelestialBodyType bodyType)
        {
            return _type == bodyType;
        }
        public bool CompareType(CelestialBody celestialBody)
        {
            return celestialBody.CompareType(_type);
        }
    }
}
