using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private Movement playerMovement;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = gameObject.GetComponent<Movement>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Ground") {
            anim.SetBool("MarioJump", false);
            playerMovement.canJump = true;
        }
    }
}
