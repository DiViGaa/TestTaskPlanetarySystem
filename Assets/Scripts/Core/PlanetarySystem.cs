using System.Collections.Generic;
using Interfases;
using UnityEngine;

namespace Core
{
    public class PlanetarySystem :MonoBehaviour, IPlanetarySystem
    {
        public List<IPlanetaryObject> planets = new List<IPlanetaryObject>();
        public IEnumerable<IPlanetaryObject> PlanetaryObjects => planets;

        public void GeneratePlanets(int count, double totalMass, Transform parent)
        {
            double remainingMass = totalMass;

            for (int i = 0; i < count; i++)
            {
                double mass = Random.Range((float)(totalMass / (count * 2)), (float)(totalMass / count));
                remainingMass -= mass;

                GameObject planetObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                planetObj.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            
                Planet planet = planetObj.AddComponent<Planet>();
                planet.transform.SetParent(parent);
                planet.Initialize(mass);
                planets.Add(planet);
            }
        }

        public void Update()
        {
            foreach (var planet in planets)
            {
                (planet as Planet)?.transform.Rotate(Vector3.up, Time.deltaTime * 10f);
            }
        }
    }
}
