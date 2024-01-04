using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinGameManager : MonoBehaviour
{
    public static MinGameManager Instance;

    public GameObject PlayerSpawnPosition;
    private void Awake()
    {
        Instance = this;
    }
}
