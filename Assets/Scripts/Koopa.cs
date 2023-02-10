using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koopa : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move() { 
        rb.velocity = new Vector2(walkSpeed * direction * Time.deltaTime, rb.velocity.y);
    }

    public override void TurnAround() {
        if (direction > 0) {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        direction = -direction;
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Block") {
            TurnAround();
        }
    }

    void OnTriggerExit2D(Collider2D coll) {
        if (coll.gameObject.tag == "Ground") {
            TurnAround();
        }
    }
}
