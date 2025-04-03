using System.Collections.Generic;

namespace Interfases
{
    public interface IPlanetarySystem
    {
        IEnumerable<IPlanetaryObject> PlanetaryObjects { get; }
        void Update();
    }
}
