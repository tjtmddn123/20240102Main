using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Player"))
        {
            collision.gameObject.transform.position = MinGameManager.Instance.PlayerSpawnPosition.transform.position;//일단 임시로 플레이어 이동
            //여기 부분을 씬 리로드를 할 지 결정해야댐. 왜냐하면 트랩의 재사용을 할지안할지 결정해야댐.
            Destroy(gameObject);
        }
    }
}
