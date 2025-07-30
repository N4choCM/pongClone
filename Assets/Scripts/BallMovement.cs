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

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float currentSpeed = speed + (count * increase);
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.linearVelocity = dir * currentSpeed;
    }

    public void IncreaseCount()
    {
        if (count * increase + speed < maxSpeed)
        {
            count++;
        }
    }

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
