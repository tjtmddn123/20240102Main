using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject settingsImage; // 설정 이미지 오브젝트

    // 메뉴 버튼이 클릭됐을 때 호출되는 함수
    public void OnMenuButtonClicked()
    {
        // 게임 진행 멈추기
        Time.timeScale = 0;

        // 설정 이미지 활성화
        settingsImage.SetActive(true);
    }
}
