using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GodzillaHealth : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject tankLaser;

    // starting health value
    public int health = 100;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected with: " /* + other.gameObject.name*/);

        // decrease health if collision with bullet (Laser To Be) 
        if (other.collider.name.Contains(tankLaser.name))
            {
            health -= 10;
            Debug.Log("Godzilla hit by bullet! Health: " + health);

            if (health <= 0)
            {
                health = 0;
                SceneManager.LoadScene("GameOver");
            }
        }
        // die if collision with other
        
        if (other.gameObject.CompareTag("helicopter"))
        {
            health = 0;
            Debug.Log("Godzilla hit by tank or helicopter! Health: " + health);
        }
    }
}
