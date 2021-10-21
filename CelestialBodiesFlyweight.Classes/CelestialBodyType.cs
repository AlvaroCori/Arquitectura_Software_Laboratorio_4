using System;

namespace CelestialBodiesFlyweight.Classes
{
    public class CelestialBodyType : ICelestialBodyType
    {
        private string _objectType;
        private string[] _colors;
        public CelestialBodyType(string objectType, string[] colors)
        {
            _objectType = objectType;
            _colors = colors;
        }
        public string GetInfo()
        {
            string colors = "";
            foreach (string color in _colors)
            {
               colors += $"{color} ";
            }
            return $"objeto: {_objectType}\ncolores: {colors}"; 
        }
        public bool CompareType(string typeBody)
        {
            return typeBody == _objectType;
        }

    }
}
