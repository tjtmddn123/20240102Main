using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorFlat : MonoBehaviour
{
    
    void Start()
    {
        Tween myTween = transform.DOMoveY(4.5f, 21f);

        myTween.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);

        myTween.Play();
    }
}
