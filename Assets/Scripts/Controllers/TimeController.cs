using UnityEngine;
using System;

public class TimeController : MonoBehaviour
{
    public float secondsPerDay = 1f;

    TimeModel model;
    DateTime current;

    public void Init(TimeModel m)
    {
        model = m;
        current = DateTime.Now;
        model.SetTime(current);
    }

    void Update()
    {
        // On s'assure que le modèle existe et n'est pas en pause
        if (model == null || !model.IsPlaying) return;

        current = current.AddDays(Time.deltaTime * secondsPerDay);
        model.SetTime(current);
    }
}