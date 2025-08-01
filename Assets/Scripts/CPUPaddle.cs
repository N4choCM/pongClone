using System;
using UnityEngine;

public class CPUPaddle : MonoBehaviour
{
    public float speed;
    public GameObject ball;

    /* 
     * This script controls the CPU paddle's movement in the game
     * The paddle moves up or down based on the ball's position
     * If the ball is more than 50 units away vertically, the paddle moves towards it
     * If the ball is within 50 units, the paddle stops moving
     * This allows the CPU paddle to track the ball effectively without overshooting
     */
    private void FixedUpdate()
    {
        if (MathF.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 1) * speed;
            }
            else
            {
                GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -1) * speed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        }
    }
}
