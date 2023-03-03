using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float walkAcceleration;
    public float runAcceleration;
    public float runDelay;
    public float maxSpeed;
    public float jumpHeight;
    public Rigidbody2D rb;
    public bool canJump;
    private float runTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        canJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if ( x < 0 )
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if ( x > 0 )
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (x == 0) {
            runTimer = 0;
        } 
        else {
            runTimer += Time.deltaTime;
        }
        // Debug.Log("Runtimer: " + runTimer);

        // this.transform.position = this.transform.position + new Vector3(x, 0, 0);
        // this.transform.position += new Vector3(x * movementSpeed * Time.deltaTime, 0, 0);
        if (Mathf.Abs(rb.velocity.x) < maxSpeed) {
            if (runTimer  > runDelay) {
                rb.velocity += new Vector2(x * runAcceleration * Time.deltaTime, 0);
            }
            else {
                rb.velocity += new Vector2(x * walkAcceleration * Time.deltaTime, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump == true) {
            rb.velocity += new Vector2(0, jumpHeight);
            canJump = false;
        }
    }
}
