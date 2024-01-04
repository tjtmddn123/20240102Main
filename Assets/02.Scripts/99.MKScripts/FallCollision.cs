using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("닿았다");
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.transform.position = MinGameManager.Instance.PlayerSpawnPosition.transform.position;
        }
    }
}
