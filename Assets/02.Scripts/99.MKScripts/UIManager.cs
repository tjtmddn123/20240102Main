using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Animator fadeInAndOutUi;

    private void Awake()
    {
        Instance = this;
    }
}
