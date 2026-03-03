using UnityEngine;
using System;

public class AppBootstrapper : MonoBehaviour
{
    public SolarSystemConfig config;
    public PlanetView[] planets;
    
    TimeModel timeModel;
    PlanetSystemController controller;

    void Start()
    {
        Debug.Log("[BOOT] Initializing application");
        
        // 1. On crée le modèle
        timeModel = new TimeModel();
        
        // 2. On crée le service
        var ephemeris = new PlanetEphemerisService();
        
        // 3. On crée le contrôleur en lui donnant le modèle, le service et les vues
        controller = new PlanetSystemController(
            timeModel,
            ephemeris,
            planets
        );
        
        // 4. On lance la simulation à la date d'aujourd'hui !
        timeModel.SetTime(DateTime.Now);
    }
}