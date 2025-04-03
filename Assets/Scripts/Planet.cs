using UnityEngine;

public class Planet : MonoBehaviour, IPlaneteryObject
{
    [SerializeField] private Enums.Enums.MassClassEnum _planetType;
    [SerializeField] private double _planetMass;
    
    public Enums.Enums.MassClassEnum PlanetType { get; set; }
    public double PlanetMass { get;  set; }
}
