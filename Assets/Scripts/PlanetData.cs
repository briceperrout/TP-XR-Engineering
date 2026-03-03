using System;
using UnityEngine;

public static class PlanetData
{
    // L'énumération exacte que ton PlanetView et tes Services attendent
    public enum Planet
    {
        Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
    }

    // La fonction exacte que ton service appelle
    public static Vector3 GetPlanetPosition(Planet planet, DateTime time)
    {
        if (planet == Planet.Sun) return Vector3.zero;

        // --- FAUSSES DONNÉES TEMPORAIRES ---
        // Juste pour que ça tourne visuellement en attendant le vrai script du prof
        float distance = (int)planet * 2f; // Éloigne un peu chaque planète
        float speed = 1f / (int)planet;    // Les planètes lointaines tournent plus doucement
        
        // On utilise les jours écoulés pour calculer un angle
        float angle = (float)(time - DateTime.MinValue).TotalDays * speed;

        float x = Mathf.Cos(angle) * distance;
        float z = Mathf.Sin(angle) * distance;

        return new Vector3(x, 0, z);
    }
}