using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpZone : MonoBehaviour
{
    SpriteRenderer _rend;

    private void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _rend.color = Color.blue;
            Rigidbody2D _rb = collision.gameObject.GetComponent<Rigidbody2D>();
            _rb.velocity = new Vector2(_rb.velocity.x, 30f);
        }
    }
}
