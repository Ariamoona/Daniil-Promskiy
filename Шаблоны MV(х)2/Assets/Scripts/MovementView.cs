using UnityEngine;

public class MovementView : MonoBehaviour
{
    public void UpdatePosition(Vector2 newPosition)
    {
        transform.position = newPosition;
    }
}