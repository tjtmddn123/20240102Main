using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 플레이어 태그를 가진 오브젝트와의 충돌을 감지
        if (collision.gameObject.tag == "Player")
        {
            // 스타트 씬으로 이동
            SceneManager.LoadScene("StartScene");
        }
    }
}

