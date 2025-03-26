using UnityEngine.Events;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public event UnityAction<Vector2> MovementInput;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        MovementInput?.Invoke(new Vector2(horizontal, vertical));
    }
}
