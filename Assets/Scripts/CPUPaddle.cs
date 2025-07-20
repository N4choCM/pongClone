using UnityEngine;
using UnityEngine.InputSystem;

public class CPUPaddle : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float up  = Keyboard.current.wKey.isPressed  ? 1f : 0f;
        float down = Keyboard.current.sKey.isPressed ? -1f : 0f;
        float v = up + down;
        rb.linearVelocity = new Vector2(0f, v * speed);
    }
}
