using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform portalExit; // 포탈2 오브젝트의 Transform

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 플레이어 태그와 충돌 감지
        if (collision.gameObject.CompareTag("Player"))
        {
            // 플레이어를 포탈2의 위치로 이동
            collision.gameObject.transform.position = portalExit.position;
        }
    }
}

