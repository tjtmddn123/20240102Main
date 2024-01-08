using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTrap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 플레이어 태그와 충돌 감지
        if (collision.gameObject.CompareTag("Player"))
        {
            // 이 오브젝트를 비활성화하거나 파괴
            // gameObject.SetActive(false); 
            Destroy(gameObject); 
        }
    }
}

