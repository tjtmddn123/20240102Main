using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgmSource; // 인스펙터에서 할당할 배경음악 소스

    void Start()
    {
        // 배경음악 재생 시작
        bgmSource.Play();
    }
}


