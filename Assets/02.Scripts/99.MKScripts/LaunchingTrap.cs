using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchingTrap : MonoBehaviour
{
    private Tween LaunchingTrapTw;
    private void OnEnable()
    {
        LaunchObjectWithTween();
    }
    private void LaunchObjectWithTween()
    {
        LaunchingTrapTw = transform.DOMoveX(transform.position.x - 2.2f, 0.2f)
            .SetEase(Ease.Linear);
    }

    private void OnDisable()
    {
        LaunchingTrapTw.Kill();
    }
}
