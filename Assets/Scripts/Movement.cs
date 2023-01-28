using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float jumpHeight;
    public Rigidbody2D rb;
    public bool canJump;

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
        // this.transform.position = this.transform.position + new Vector3(x, 0, 0);
        this.transform.position += new Vector3(x * movementSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canJump == true) {
            rb.velocity += new Vector2(0, jumpHeight);
            canJump = false;
        }
    }
}
