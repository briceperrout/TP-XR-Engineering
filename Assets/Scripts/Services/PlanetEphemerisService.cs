using System;
using UnityEngine;

public interface IPlanetEphemerisService
{
    Vector3 GetPlanetPosition(PlanetData.Planet planet, DateTime date);
}

public class PlanetEphemerisService : IPlanetEphemerisService
{
    public Vector3 GetPlanetPosition(PlanetData.Planet planet, DateTime date)
    {
        return PlanetData.GetPlanetPosition(planet, date);
    }
}