using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorFlat : MonoBehaviour
{
    private Tween elevatorTw;
    private Tween invisibleTrapTw;
    public bool iselevator;
    public bool upFlatTrap;

    private void OnEnable()
    {
        if (!iselevator)
        {
            invisibleTrapTw = DOTween.Sequence()
            .Append(transform.DOMoveY(-3f, 1f).SetEase(Ease.Linear))
            .Append(transform.DOMoveY(0f, 1f).SetEase(Ease.Linear));
        }
        if (upFlatTrap)
        {
            Debug.Log("velo");
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = new Vector2 (0f, 2f);
        }
    }
    void Start()
    {
        if (iselevator)
        {
            elevatorTw = transform.DOMoveY(4.5f, 21f);

            elevatorTw.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);

            elevatorTw.Play();
        }
    }

    private void OnDisable()
    {
        elevatorTw.Kill();
        invisibleTrapTw.Kill();
    }
}
