using Interfases;
using UnityEngine;

namespace Core
{
    public class PlanetarySystemFactory : MonoBehaviour, IPlanetarySystemFactory
    {
        public static GameObject planetarySystemObj;
        
        public IPlanetarySystem Create(double totalMass)
        {
            planetarySystemObj = new GameObject("PlanetarySystem");
            PlanetarySystem planetarySystem = planetarySystemObj.AddComponent<PlanetarySystem>();
            planetarySystem.GeneratePlanets(Random.Range(3, 8), totalMass, planetarySystemObj.transform);
            return planetarySystem;
        }
    }
}
