using Unity.VisualScripting;
using UnityEngine;

public class PaddleCollisionControl : MonoBehaviour
{
    public BallMovement bm;
    public Scoring scoring;

    /*
     * This script handles the collision detection between the ball and the paddles.
     * It determines the direction of the ball's movement after a collision with a paddle.
     */
    void ReboundWithPaddle(Collision2D c)
    {
        Vector3 ballPosition = transform.position;
        Vector3 paddlePosition = c.gameObject.transform.position;
        float paddleHeight = c.collider.bounds.size.y;
        float x;

        if (c.gameObject.name == "Player Paddle")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - paddlePosition.y) / paddleHeight;

        bm.IncreaseCount();
        bm.MoveBall(new Vector2(x, y));
    }

    /*
     * This method is called when a collision occurs with the ball.
     * It checks the name of the collided object to determine if it is a paddle or a wall.
     * If it is a paddle, it calls ReboundWithPaddle to handle the rebound logic.
     * If it is a wall, it updates the score and reinitializes the ball position.
     */
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player Paddle" || c.gameObject.name == "CPU Paddle")
        {
            ReboundWithPaddle(c);
        }
        else if (c.gameObject.name == "Left Wall")
        {
            scoring.AddCpuScore();
            StartCoroutine(this.bm.InitBall(true));
        }
        else if (c.gameObject.name == "Right Wall")
        {
            scoring.AddPlayerScore();
            StartCoroutine(this.bm.InitBall(false));
        }
    }
}
