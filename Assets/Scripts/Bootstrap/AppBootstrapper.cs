using UnityEngine;

public class AppBootstrapper : MonoBehaviour
{
    public SolarSystemConfig config;
    public PlanetView[] planets;
    
    // On ajoute la référence au TimeController
    public TimeController timeController; 
    
    TimeModel timeModel;
    PlanetSystemController controller;

    void Start()
    {
        Debug.Log("[BOOT] Initializing application");
        
        timeModel = new TimeModel();
        var ephemeris = new PlanetEphemerisService();
        
        controller = new PlanetSystemController(
            timeModel,
            ephemeris,
            planets
        );
        
        // C'est le TimeController qui gère la date maintenant !
        timeController.Init(timeModel); 
    }
}