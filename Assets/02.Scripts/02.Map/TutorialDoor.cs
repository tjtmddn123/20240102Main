using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // 현재 씬의 인덱스를 가져옴
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // 다음 씬의 인덱스 계산
            int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;

            // 다음 씬 로드
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}


