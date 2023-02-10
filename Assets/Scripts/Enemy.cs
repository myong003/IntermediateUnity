using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float walkSpeed;
    protected int direction = 1;
    protected Rigidbody2D rb;
    public abstract void Move();
    public abstract void TurnAround();
}
