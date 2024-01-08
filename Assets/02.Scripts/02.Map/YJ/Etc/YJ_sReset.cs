using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YJ_sReset : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Transform startPosition;
    public void OnResetClick()
    {
        player.transform.position = startPosition.position;
        Time.timeScale = 1.0f;
    }
}
