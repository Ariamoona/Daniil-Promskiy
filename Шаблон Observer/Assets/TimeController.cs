using UnityEngine;
using System;

public class TimeController : MonoBehaviour
{
    public float dayDuration = 60f;
    private float timer = 0f;

    public event Action<float> OnTimeChanged;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= dayDuration) timer -= dayDuration;

        float progress = timer / dayDuration;
        OnTimeChanged?.Invoke(progress);
    }
}