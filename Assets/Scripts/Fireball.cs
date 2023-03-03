using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject fireball; 
    public float launchVelocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Fire1") )
        {
            //Instantiate(object being created, position, rotation)
            GameObject ball = Instantiate(fireball, transform.position + (transform.right * 1), transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector3(launchVelocity, 0, 0));

            //Destroy(object being destroyed, how long until it is destroyed)
            Destroy(ball, 5f);
        }
    }
}
