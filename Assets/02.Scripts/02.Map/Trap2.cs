using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위한 네임스페이스 추가

public class Trap2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "Player" 태그를 가진 오브젝트가 트랩에 충돌할 경우
        if (other.gameObject.CompareTag("Player"))
        {
            // 현재 씬을 재시작
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

