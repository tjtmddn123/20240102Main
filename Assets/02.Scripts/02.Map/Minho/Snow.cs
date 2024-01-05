using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    Camera _camera;
    GameObject snow;
    private void Start()
    {
        _camera = Camera.main;
        snow = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 10f);
        Debug.DrawRay(transform.position, Vector2.down * 10f, Color.magenta, 0.3f);

        if (hit.collider != null && hit.collider.gameObject.CompareTag("Player"))
        {
            snow.SetActive(true);
        }
    }
}
