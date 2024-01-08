using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour
{
    PanelActivator panelActivator;
    private void Start()
    {
        panelActivator = GetComponent<PanelActivator>();
    }
    private void OnEnable()
    {
        DeathTrigger.onPanel += HandlePanel;
    }

    private void OnDisable()
    {
        DeathTrigger.onPanel -= HandlePanel;
    }

    private void HandlePanel()
    {
        panelActivator.OnPanel();
    }
}
