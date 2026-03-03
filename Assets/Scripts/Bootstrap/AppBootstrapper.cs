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
        
        // 4. On initialise à la date d'aujourd'hui
        timeModel.SetTime(DateTime.Now);

        // 5. ON ACCÉLÈRE LE TEMPS ICI (50 jours s'écoulent par seconde !)
        timeModel.SetScale(5f);
    }

    void Update()
    {
        // On vérifie que le modèle existe et que le temps n'est pas en pause
        if (timeModel != null && timeModel.IsPlaying)
        {
            // Time.deltaTime est le temps réel écoulé depuis la dernière frame (ex: 0.016s)
            // Multiplié par notre TimeScale (50), ça donne le nombre de jours à avancer
            double daysToAdd = Time.deltaTime * timeModel.TimeScale;
            
            // On calcule la nouvelle date et on prévient le modèle !
            DateTime newDate = timeModel.CurrentTime.AddDays(daysToAdd);
            timeModel.SetTime(newDate);
        }
    }
}