using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] points; // 이동할 위치들
    public float speed = 2f;   // 이동 속도
    private int currentPointIndex = 0; // 현재 목표 위치

    void Update()
    {
        // 현재 위치에서 다음 포인트까지 이동
        transform.position = Vector2.MoveTowards(transform.position, points[currentPointIndex].position, speed * Time.deltaTime);

        // 목표 위치에 도달하면 다음 위치로 변경
        if (Vector2.Distance(transform.position, points[currentPointIndex].position) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % points.Length;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.activeInHierarchy)
        {
            // 발판이 활성화 상태일 때만 부모 설정 변경
            other.transform.SetParent(null);
        }
    }

}

