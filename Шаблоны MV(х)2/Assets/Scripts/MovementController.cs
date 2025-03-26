using UnityEngine;

public class MovementController
{
    private MovementModel _model;
    private MovementView _view;

    public MovementController(MovementModel model, MovementView view)
    {
        _model = model;
        _view = view;
    }

    public void Move(Vector2 direction)
    {
        _model.Position += direction * _model.Speed * Time.deltaTime;
        _view.UpdatePosition(_model.Position);
    }
    public MovementController(MovementModel model, MovementView view, InputHandler input)
    {
        
        input.MovementInput += HandleMovement;
    }

    private void HandleMovement(Vector2 direction)
    {
        Move(direction);
    }
}