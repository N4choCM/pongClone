using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public float increase;
    public float maxSpeed;
    int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(InitBall());
    }

    /* 
     * Initializes the ball position and starts the movement
     * If playerStarts is true, the player starts the game, otherwise the CPU starts
     * Waits for 2 seconds before starting the ball movement
     * This allows the player to prepare for the game
     */
    public IEnumerator InitBall(bool playerStarts = true)
    {
        this.ResetBall(playerStarts);
        count = 0;
        yield return new WaitForSeconds(2);
        if (playerStarts)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    /*
     * Moves the ball in a specified direction with a normalized vector
     * The speed of the ball is calculated based on the current count and increase factor
     * This allows the ball to move faster as the game progresses
     * The linear velocity of the Rigidbody2D component is set to the calculated speed in the specified direction
     */
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float currentSpeed = speed + (count * increase);
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.linearVelocity = dir * currentSpeed;
    }

    // Increases the movement count of the ball
    public void IncreaseCount()
    {
        if (count * increase + speed < maxSpeed)
        {
            count++;
        }
    }

    /* 
     * Resets the ball position and velocity
     * If playerStarts is true, the ball is positioned on the left side of the screen
     * If playerStarts is false, the ball is positioned on the right side of the screen
     * The ball's linear velocity is set to zero, stopping its movement
     * This method is called when a point is scored
     */
    void ResetBall(bool playerStarts)
    {
        this.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        if(playerStarts)
        {
            gameObject.transform.localPosition = new Vector3(-100, 0, 10);
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(100, 0, 10);
        }
    }
}
