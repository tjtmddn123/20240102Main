using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndButton : MonoBehaviour
{
    public Button endButton; // 인스펙터에서 할당할 스타트 버튼

    void Start()
    {
        // 버튼의 클릭 이벤트에 메서드를 연결
        endButton.onClick.AddListener(OnEndButtonClick);
    }

    // 스타트 버튼이 클릭되었을 때 호출될 메서드
    void OnEndButtonClick()
    {
        Invoke("LoadStartScene", 1f); // 1초 후에 'LoadTutorialScene' 메서드를 호출
    }

    // 튜토리얼 씬을 로드하는 메서드
    void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene"); // "튜토리얼" 씬을 로드
    }
}
