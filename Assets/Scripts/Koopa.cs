using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koopa : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        Debug.Log("hi");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move() { 
        rb.velocity = new Vector2(walkSpeed * direction * Time.deltaTime, rb.velocity.y);
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
