using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="XR/Solar system config")]
public class SolarSystemConfig : ScriptableObject
{
    public float distanceScale = 0.000001f;
    public float planetSizeScale = 0.01f;
    public bool showOrbits = true;
}
