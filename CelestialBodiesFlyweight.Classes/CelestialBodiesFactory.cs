using System;
using System.Collections.Generic;
namespace CelestialBodiesFlyweight.Classes
{
    public class CelestialBodiesFactory
    {
        private ICelestialBodyType[] _celestialBodiesType;
        private int _size;
        public CelestialBodiesFactory(ICelestialBodyType[] celestialBodiesType)
        {
            _celestialBodiesType = celestialBodiesType;
            _size = 0;
        }
        private ICelestialBodyType Find(string typeBody)
        {
            if (_size == 0)
                return null; 
            for (int index = 0 ; index < _size; index = index + 1)
            {
                if (_celestialBodiesType[index].CompareType(typeBody))
                    return _celestialBodiesType[index];
            }
            return null;
        }
        private void AddCelestialBody(ICelestialBodyType typeObject)
        {
            _celestialBodiesType[_size] = typeObject;
            _size = _size + 1;
        }
        public ICelestialBodyType GetCelestialBodyType(string typeBody,string[] colors)
        {
            ICelestialBodyType typeObject = Find(typeBody);
            if (typeObject == null)
            {
                typeObject = new CelestialBodyType(typeBody, colors);
                AddCelestialBody(typeObject);
            }
            return typeObject;
        }
    }
}
