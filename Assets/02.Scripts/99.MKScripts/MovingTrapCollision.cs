using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrapCollision : TrapCollision
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);

        if (collision.collider.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
