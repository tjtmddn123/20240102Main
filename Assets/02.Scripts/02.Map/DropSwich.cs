using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSwitch : MonoBehaviour
{
    public GameObject dropPrefab; // 드랍 오브젝트 프리팹

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 현재 오브젝트의 위치에서 Y축으로 10만큼 이동한 위치 계산
            Vector3 spawnPosition = transform.position + new Vector3(0, 5, 0);

            // 플레이어와의 충돌 감지 시 드랍 오브젝트 생성
            Instantiate(dropPrefab, spawnPosition, Quaternion.identity);
        }
    }
}

