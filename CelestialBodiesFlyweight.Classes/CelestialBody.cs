using System;

namespace CelestialBodiesFlyweight.Classes
{
    public class CelestialBody
    {
        private ICelestialBodyType _type;
        private string _name;
        private double _x;
        private double _y;
        private double _z;
        public string Name {
            get{ return _name;}
        }
        public CelestialBody(ICelestialBodyType myType, string name, double x, double y,double z)
        {
            _type = myType;
            _name = name;
            _x = x;
            _y = y;
            _z = z;
        }
        public string GetInfo()
        {
            return $"nombre: {_name}\ncoordenadas: ({_x} UA , {_y} UA , {_z} UA)\n{_type.GetInfo()}";
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
