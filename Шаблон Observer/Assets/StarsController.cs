using UnityEngine;

public class StarsController : MonoBehaviour
{
    [SerializeField] private AnimationCurve alphaCurve;

    private SpriteRenderer[] stars;

    private void Start()
    {
        stars = GetComponentsInChildren<SpriteRenderer>();
        FindObjectOfType<TimeController>().OnTimeChanged += UpdateAlpha;
    }

    private void UpdateAlpha(float progress)
    {
        float alpha = alphaCurve.Evaluate(progress);
        foreach (var star in stars)
        {
            Color color = star.color;
            color.a = alpha;
            star.color = color;
        }
    }
}