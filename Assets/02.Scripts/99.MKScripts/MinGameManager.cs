using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinGameManager : MonoBehaviour
{
    public static MinGameManager Instance;
    private float time;
    private int currentIndex = 0;

    public GameObject[] autoTrap;
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (autoTrap != null && autoTrap.Length > 0)
        {
            time += Time.deltaTime;

            if (time >= 2)
            {
                if (currentIndex < autoTrap.Length)
                {
                    autoTrap[currentIndex].SetActive(true);
                    currentIndex++;
                    time = 0;
                }
                else
                {
                    currentIndex = 0;
                }
            }
        }
    }
}
