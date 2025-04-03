
using System.Collections.Generic;

namespace Interfases
{
    public interface IPlanetaryObject
    {
        Enums.Enums.MassClassEnum MassClass { get; }
        double Mass { get; }
    }
}
