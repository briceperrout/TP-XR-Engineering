using UnityEngine;
using System;

public class PlanetSelectable : MonoBehaviour
{
    [Header("Configuration")]
    public PlanetView planetView;

    // Événement statique : n'importe quel script (comme le FocusController) 
    // peut s'abonner pour savoir quand UNE planète a été sélectionnée.
    public static event Action<PlanetView> OnPlanetSelected; 

    /// <summary>
    /// Cette méthode doit être appelée par l'événement "Select Entered" 
    /// du composant XR Simple Interactable de la planète.
    /// </summary>
    public void SelectPlanet()
    {
        if (planetView != null)
        {
            Debug.Log($"[XR] Tentative de sélection de : {planetView.planet}");
            
            // On déclenche l'événement en passant la vue de la planète
            OnPlanetSelected?.Invoke(planetView);
        }
        else
        {
            Debug.LogWarning($"[XR] PlanetSelectable sur {gameObject.name} n'a pas de PlanetView assignée !");
        }
    }
}