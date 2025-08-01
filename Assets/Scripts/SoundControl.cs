using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource paddleSound;
    public AudioSource wallSound;

    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.name == "Player Paddle" || c.gameObject.name == "CPU Paddle")
        {
            paddleSound.Play();
        }
        else
        {
            wallSound.Play();
        }
    }
}
