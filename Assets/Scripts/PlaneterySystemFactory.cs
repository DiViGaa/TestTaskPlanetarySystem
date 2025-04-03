using System.Collections.Generic;
using Interfases;
using UnityEngine;

public class PlaneterySystemFactory : MonoBehaviour, IPlanetarySystemFactory
{
    private List<IPlaneteryObject> _planets = new List<IPlaneteryObject>();
    private List<GameObject> _planetObjects = new List<GameObject>();

    private void Start()
    {
        var planetObjectsArr = Resources.LoadAll<GameObject>("Prefabs");
        _planetObjects = new List<GameObject>(planetObjectsArr);
    }

    public IPlaneteryObject CreatePlanet(double mass)
    {
        return null;
    }
}
