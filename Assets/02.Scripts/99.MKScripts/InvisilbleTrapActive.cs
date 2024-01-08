using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleTrapActive : MonoBehaviour
{
    private Sequence sequence;
    private Vector3 initialPosition;
    private Vector3 initialLocalScale;
    public float timeInterval;
    public bool LeftTrap;

    void Awake()
    {
        // OnEnable을 쓸거라서 초기 위치 저장이 필요함, 안쓰면 껐다키거나 할때 위치 달라짐.
        initialPosition = transform.position;
        initialLocalScale = transform.localScale;
    }

    private void OnEnable()
    {
        TrapSequence();
    }

    private void TrapSequence()
    {
        sequence = DOTween.Sequence();
        
        // 대기시간
        sequence.AppendInterval(timeInterval);

        // 시퀀스 동시 시작
        Tweener scaleTween = transform.DOScale(new Vector3(1f, 1.5f, 1f), 1f);
        sequence.Append(scaleTween);

        if (LeftTrap)
        {
            Tweener positionTween = transform.DOMoveX(transform.position.x + 0.75f, 1f);
            sequence.Join(positionTween);
        }

        else
        {
            Tweener positionTween = transform.DOMoveX(transform.position.x - 0.75f, 1f);
            sequence.Join(positionTween);
        }

        // 1초 동안 유지
        sequence.AppendInterval(1f);

        // 원상복귀
        Tweener scaleTween2 = transform.DOScale(new Vector3(1f, 0, 1f), 1f);
        sequence.Join(scaleTween2);

        Tweener positionTween2 = transform.DOMoveX(transform.position.x, 1f);
        sequence.Join(positionTween2);
    }

    private void OnDisable()
    {
        // 껏을때 초기화 해주기.
        transform.position = initialPosition;
        transform.localScale = initialLocalScale;
        sequence.Kill();
    }
}
