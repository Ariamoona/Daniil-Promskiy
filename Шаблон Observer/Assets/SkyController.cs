using UnityEngine;

public class SkyController : MonoBehaviour
{
    public Color nightColor;
    public Color morningColor;
    public Color dayColor;
    public Color eveningColor;

    private Camera mainCam;

    private void Start()
    {
        mainCam = Camera.main;
        FindObjectOfType<TimeController>().OnTimeChanged += UpdateSky;
    }

    private void UpdateSky(float progress)
    {
        int phase = (int)(progress * 4);
        float phaseProgress = (progress * 4) % 1f;

        Color color = phase switch
        {
            0 => Color.Lerp(nightColor, morningColor, phaseProgress),
            1 => Color.Lerp(morningColor, dayColor, phaseProgress),
            2 => Color.Lerp(dayColor, eveningColor, phaseProgress),
            _ => Color.Lerp(eveningColor, nightColor, phaseProgress)
        };

        mainCam.backgroundColor = color;
    }
}