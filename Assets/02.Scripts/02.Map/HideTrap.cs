using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTrap : MonoBehaviour
{
    public GameObject trapObject; // Inspector에서 할당할 함정 오브젝트

    private void OnTriggerEnter2D(Collider2D other)
    {
        // "Player" 태그를 가진 오브젝트가 함정에 충돌할 경우
        if (other.gameObject.CompareTag("Player"))
        {
            // 함정 오브젝트를 활성화
            trapObject.SetActive(true);
        }
    }
}


