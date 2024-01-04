using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class AnimationController : Animations
{
    private static readonly int Run = Animator.StringToHash("Run");

    // Start 메서드는 첫 번째 프레임 업데이트 전에 호출
    void Start()
    {
        // 공격과 이동 이벤트에 메서드를 연결
        controller.OnMoveEvent += Move;
    }

    // 이동을 처리하는 메서드
    private void Move(Vector2 obj)
    {
        // 캐릭터가 이동 중인지 여부를 애니메이터 파라미터로 설정
        animator.SetBool(Run, obj.magnitude > .5f);
    }
}
