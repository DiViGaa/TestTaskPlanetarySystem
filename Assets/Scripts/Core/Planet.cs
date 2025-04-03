using Interfases;
using UnityEngine;

namespace Core
{
    public class Planet : MonoBehaviour, IPlanetaryObject
    {
        public Enums.Enums.MassClassEnum MassClass { get; private set; }
        public double Mass { get; private set; }
        
        private Renderer planetRenderer;
        public Transform OrbitParent { get; private set; }
        public float OrbitRadius { get; private set; }
        public float OrbitSpeed { get; private set; }

        public void Initialize(double mass, Transform center, float radius, float speed, Transform parent)
        {
            Mass = mass;
            MassClass = DetermineMassClass(mass);
            OrbitRadius = radius;
            OrbitSpeed = speed;

            float scale = Mathf.Clamp((float)Mass, 0.1f, 10f);
            transform.localScale = new Vector3(scale, scale, scale);

            planetRenderer = GetComponent<Renderer>();
            if (planetRenderer != null)
            {
                planetRenderer.material.color = new Color(Random.value, Random.value, Random.value);
            }

            OrbitParent = new GameObject("OrbitParent").transform;
            OrbitParent.SetParent(parent);
            OrbitParent.position = center.position;
            transform.parent = OrbitParent;

            transform.position = center.position + new Vector3(OrbitRadius, 0, 0);
        }

        private Enums.Enums.MassClassEnum DetermineMassClass(double mass)
        {
            return mass switch
            {
                < 0.00001 => Enums.Enums.MassClassEnum.Asteroidan,
                < 0.1 => Enums.Enums.MassClassEnum.Mercurian,
                < 0.5 => Enums.Enums.MassClassEnum.Subterran,
                < 2 => Enums.Enums.MassClassEnum.Terran,
                < 10 => Enums.Enums.MassClassEnum.Superterran,
                < 50 => Enums.Enums.MassClassEnum.Neptunian,
                _ => Enums.Enums.MassClassEnum.Jovian
            };
        }
    }
}
