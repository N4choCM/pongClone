using System.Collections;
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

    public IEnumerator InitBall(bool playerStarts = true)
    {
        this.count = 0;
        yield return new WaitForSeconds(2);
        if (playerStarts)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float currentSpeed = speed + (count * increase);
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.linearVelocity = dir * currentSpeed;
    }

    public void IncreaseCount()
    {
        if (this.count * increase + speed < maxSpeed)
        {
            this.count++;
        }
    }
}
