using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float walkSpeed;
    protected int direction = 1;
    protected Rigidbody2D rb;

    protected virtual void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    public abstract void Move();
    public virtual void TurnAround() {
        if (direction > 0) {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        direction = -direction;
    }
}
