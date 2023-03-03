using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        fireballBounce();
    }

    void fireballBounce()
    {
        if ( rb.velocity.y < velocity.y )
        {
            rb.velocity = velocity;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        rb.velocity = new Vector2(velocity.x, -velocity.y);
        if ( col.gameObject.tag == "Enemy" )
        {
            Destroy(col.gameObject);
        }
    }
}
