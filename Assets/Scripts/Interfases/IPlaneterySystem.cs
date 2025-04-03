using System.Collections.Generic;

namespace Interfases
{
    public interface IPlaneterySystem
    {
        IEnumerable<IPlaneteryObject> PlaneteryObjects { get; }
        void Update(float deltaTime);
    }
}
