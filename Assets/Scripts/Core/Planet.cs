using Interfases;
using UnityEngine;

namespace Core
{
    public class Planet : MonoBehaviour, IPlanetaryObject
    {
        public Enums.Enums.MassClassEnum MassClass { get; private set; }
        public double Mass { get; private set; }

        private Renderer planetRenderer;

        public void Initialize(double mass)
        {
            Mass = mass;
            MassClass = DetermineMassClass(mass);

            float scale = Mathf.Clamp((float)Mass, 0.1f, 10f);
            transform.localScale = new Vector3(scale, scale, scale);

            planetRenderer = GetComponent<Renderer>();
            if (planetRenderer != null)
            {
                planetRenderer.material.color = new Color(Random.value, Random.value, Random.value);
            }
        }

        private Enums.Enums.MassClassEnum DetermineMassClass(double mass)
        {
            if (mass < 0.00001) return Enums.Enums.MassClassEnum.Asteroidan;
            if (mass < 0.1) return Enums.Enums.MassClassEnum.Mercurian;
            if (mass < 0.5) return Enums.Enums.MassClassEnum.Subterran;
            if (mass < 2) return Enums.Enums.MassClassEnum.Terran;
            if (mass < 10) return Enums.Enums.MassClassEnum.Superterran;
            if (mass < 50) return Enums.Enums.MassClassEnum.Neptunian;
            return Enums.Enums.MassClassEnum.Jovian;
        }
    }
}
