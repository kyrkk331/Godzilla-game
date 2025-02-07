using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class TankDeath : MonoBehaviour
{
    public GameObject Godzilla;
    private bool canDestroy;
    //void Update()
    //{
    //    // Ελέγχουμε αν ο παίκτης πάτησε Fire2
    //    //if (Input.GetButtonDown("Fire2"))
    //    //{
    //    //    canDestroy = true; // Ενεργοποιούμε τη μεταβλητή
    //    //}
    //    //else
    //    //{
    //    //    canDestroy = false;
    //    //}
    //}



    //        void OnCollisionEnter2D(Collision2D other)
    //        {
    //         canDestroy = true;  
    //            if (other.collider.name.Contains(Godzilla.name) && Input.GetButtonDown("Fire2"))//canDestroy == true)
    //            {
    //                Debug.Log("col");
    //                Destroy(gameObject);


    //            }

    //        }
    //    void OnCollisinExit2D(Collision2D other)
    //    {
    //        canDestroy = false;
    //    }
    //}



    private bool isCollidingWithGodzilla = false; // Track collision state with Godzilla

    // Called when the physical collider (non-trigger) enters
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Godzilla"))
        {
            isCollidingWithGodzilla = true; // Start the collision with Godzilla
        }
    }

    // Called when the trigger collider detects overlap
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Godzilla"))
        {
            // Optional: Do something when Godzilla enters the trigger area
            Debug.Log("Godzilla entered trigger zone.");
        }
    }

    // Called when the regular collider (physical) exits
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Godzilla"))
        {
            isCollidingWithGodzilla = false; // End the collision with Godzilla
        }
    }

    // Called when the trigger collider stops overlapping
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Godzilla"))
        {
            // Optional: Do something when Godzilla exits the trigger area
            Debug.Log("Godzilla exited trigger zone.");
        }
    }

    // Update loop to check for Fire2 input and destroy tank if it's colliding with Godzilla
    void Update()
    {
        // Only destroy if Fire2 is pressed and Godzilla is colliding with the regular collider
        if (isCollidingWithGodzilla && Input.GetButtonDown("Fire2"))
        {
            Destroy(gameObject); // Destroy this tank
        }
    }
}



