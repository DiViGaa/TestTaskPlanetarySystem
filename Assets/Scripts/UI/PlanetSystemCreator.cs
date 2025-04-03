using Core;
using Interfases;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PlanetSystemCreator : MonoBehaviour
    {
        [SerializeField] private Button createPlanetButton;
        
        [SerializeField] private TMP_InputField massInputField;

        private void OnEnable()
        {
            createPlanetButton.onClick.AddListener(CreatePlanet);
        }

        private void OnDisable()
        {
            createPlanetButton.onClick.RemoveAllListeners();
        }

        private void CreatePlanet()
        {
            IPlanetarySystemFactory factory = new PlanetarySystemFactory();
            
            if (PlanetarySystemFactory.planetarySystemObj != null)
                Destroy(PlanetarySystemFactory.planetarySystemObj.gameObject);
            
            factory.Create(double.Parse(massInputField.text));
        }
    }
}
