using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    public GameObject Godzilla;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name.Contains(Godzilla.name))
        {
            Destroy(Godzilla);
            SceneManager.LoadScene("GameOver");
        }
    }
}
