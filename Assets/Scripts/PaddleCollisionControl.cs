using Unity.VisualScripting;
using UnityEngine;

public class PaddleCollisionControl : MonoBehaviour
{
    public BallMovement bm;

    void ReboundWithPaddle(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
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

        this.bm.IncreaseCount();
        this.bm.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player Paddle" || c.gameObject.name == "CPU Paddle")
        {
            this.ReboundWithPaddle(c);
        } else if (c.gameObject.name == "Left Wall")
        {
            print("Left Wall Hit");
        } else if (c.gameObject.name == "Right Wall")
        {
            print("Right Wall Hit");
        }
    }
}
