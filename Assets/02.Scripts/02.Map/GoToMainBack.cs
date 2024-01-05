using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainBack : MonoBehaviour
{
    public GameObject settingsImage; // 설정 이미지 오브젝트

    // "메인" 버튼이 클릭됐을 때 호출되는 함수
    public void GoToMain()
    {
        // 스타트 씬으로 이동
        SceneManager.LoadScene("StartScene");
    }

    // "백" 버튼이 클릭됐을 때 호출되는 함수
    public void Back()
    {
        // 설정 이미지 비활성화
        settingsImage.SetActive(false);

        // 게임 진행 재개
        Time.timeScale = 1;
    }
}

