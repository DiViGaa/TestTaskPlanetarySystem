using System.Collections.Generic;
using Interfases;
using UnityEngine;

namespace Core
{
    public class PlanetarySystem : MonoBehaviour, IPlanetarySystem
    {
        public List<Planet> planets = new List<Planet>();
        public IEnumerable<IPlanetaryObject> PlanetaryObjects => planets;

        public void GeneratePlanets(int count, double totalMass, Transform parent)
        {
            double remainingMass = totalMass;

            float[] orbitRadii = { 5f, 7f, 10f, 14f, 19f, 25f, 32f };
            float[] orbitSpeeds = { 20f, 15f, 12f, 9f, 7f, 5f, 3f };

            for (int i = 0; i < count; i++)
            {
                if (i >= orbitRadii.Length) break;

                double mass = Random.Range((float)(totalMass / (count * 2)), (float)(totalMass / count));
                remainingMass -= mass;

                GameObject planetObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Planet planet = planetObj.AddComponent<Planet>();
                
                float orbitRadius = orbitRadii[i];
                float orbitSpeed = orbitSpeeds[i];

                planet.Initialize(mass, parent, orbitRadius, orbitSpeed, parent);
                planets.Add(planet);
            }
        }

        public void Update()
        {
            foreach (var planet in planets)
            {
                if (planet.OrbitParent != null)
                {
                    planet.OrbitParent.Rotate(Vector3.up, planet.OrbitSpeed * Time.deltaTime);
                }
            }
        }
    }
}