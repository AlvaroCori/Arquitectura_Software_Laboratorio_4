using System;

namespace CelestialBodiesFlyweight.Classes
{
    public interface ICelestialBodyType
    {
        string GetInfo();
        bool CompareType(string typeBody);
    }
}
