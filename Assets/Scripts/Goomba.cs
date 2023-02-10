using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : Enemy
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
        direction = -direction;
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Block") {
            TurnAround();
        }
    }
}
