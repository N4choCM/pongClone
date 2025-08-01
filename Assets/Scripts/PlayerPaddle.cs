using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /*
     * This script controls the player's paddle movement in the game
     * The paddle moves up or down based on player input
     * The speed of the paddle is determined by the speed variable
     * This allows the player to control the paddle effectively during gameplay
     */
    private void FixedUpdate()
    {
        float up = Keyboard.current.upArrowKey.isPressed ? 1f : 0f;
        float down = Keyboard.current.downArrowKey.isPressed ? -1f : 0f;
        float v = up + down;
        rb.linearVelocity = new Vector2(0f, v * speed);
    }
}
