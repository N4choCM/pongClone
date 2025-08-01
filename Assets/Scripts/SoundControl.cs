using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource paddleSound;
    public AudioSource wallSound;

    /*
     * This method is called when the ball collides with a paddle or a wall
     * It plays the appropriate sound based on the collision object
     */
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player Paddle" || c.gameObject.name == "CPU Paddle")
        {
            paddleSound.Play();
        }
        else
        {
            wallSound.Play();
        }
    }
}
