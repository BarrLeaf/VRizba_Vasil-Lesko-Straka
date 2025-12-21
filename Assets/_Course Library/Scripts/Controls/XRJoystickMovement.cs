using UnityEngine;
using UnityEngine.InputSystem;

public class XRJoystickMovement : MonoBehaviour
{
    public float speed = 2.5f;
    public Transform xrCamera; 
    private Vector2 moveInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log("Move input: " + moveInput);
    }

    void Update()
    {
        Vector3 forward = xrCamera.forward;
        Vector3 right = xrCamera.right;
        forward.y = 0;
        right.y = 0;

        Vector3 move = (forward * moveInput.y + right * moveInput.x) * speed * Time.deltaTime;
        transform.position += move;
    }
}
