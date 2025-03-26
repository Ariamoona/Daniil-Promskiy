using UnityEngine;

public class SunController : MonoBehaviour
{
    public Transform orbitCenter;
    public float orbitRadius = 5f;

    private void Start()
    {
        FindObjectOfType<TimeController>().OnTimeChanged += UpdatePosition;
    }

    private void UpdatePosition(float progress)
    {
        float angle = (progress * 360f - 90f) * Mathf.Deg2Rad;
        Vector2 pos = orbitCenter.position;
        pos.x += Mathf.Cos(angle) * orbitRadius;
        pos.y += Mathf.Sin(angle) * orbitRadius;
        transform.position = pos;
    }
}