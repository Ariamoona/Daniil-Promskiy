using UnityEngine;

public class MovementModel
{
    public Vector2 Position { get; set; }
    public float Speed { get; } = 5f;

   
    public MovementModel(Vector2 startPosition)
    {
        Position = startPosition;
    }
}