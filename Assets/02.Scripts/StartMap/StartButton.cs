using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton; // 인스펙터에서 할당할 스타트 버튼

    void Start()
    {
        // 버튼의 클릭 이벤트에 메서드를 연결
        startButton.onClick.AddListener(OnStartButtonClick);
    }

    // 스타트 버튼이 클릭되었을 때 호출될 메서드
    void OnStartButtonClick()
    {
        Invoke("LoadTutorialScene", 1f); // 1초 후에 'LoadTutorialScene' 메서드를 호출
    }

    // 튜토리얼 씬을 로드하는 메서드
    void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial"); // "튜토리얼" 씬을 로드
    }
}
