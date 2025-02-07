using UnityEngine;



public class HelicopterDestraction : MonoBehaviour
{//DEN DOYLEYEI
    public GameObject fireball;

    Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // Debug.Log("nn");
        if (collision.collider.name.Contains(fireball.name))
        {
            //Debug.Log("1");
            Destroy(gameObject);
            //na mpei animation
        }
    }


}
