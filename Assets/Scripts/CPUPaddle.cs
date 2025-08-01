using System;
using UnityEngine;

public class CPUPaddle : MonoBehaviour
{
    public float speed;
    public GameObject ball;

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
