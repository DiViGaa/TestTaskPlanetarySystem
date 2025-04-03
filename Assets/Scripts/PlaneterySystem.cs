using System.Collections.Generic;
using Interfases;

public class PlaneterySystem : IPlaneterySystem
{
    public IEnumerable<IPlaneteryObject> PlaneteryObjects { get; }
    public void Update(float deltaTime)
    {
        throw new System.NotImplementedException();
    }
}
