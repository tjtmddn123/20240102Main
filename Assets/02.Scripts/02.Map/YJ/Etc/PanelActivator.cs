using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActivator : MonoBehaviour
{
    public GameObject panel;

    public void OnPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
}
