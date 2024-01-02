using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // 캐릭터 컨트롤러 컴포넌트 참조
    private CharacterController _controller;
    // 이동 방향을 저장하는 변수
    private Vector2 _movementDirection = Vector2.zero;
    // Rigidbody2D 컴포넌트 참조
    private Rigidbody2D _rigidbody;

    // 이동 속도
    public float moveSpeed = 5f;
    // 점프 힘
    public float jumpForce = 10f;
    // 지면 레이어 마스크
    public LayerMask groundLayer;

    // 지면에 있는지 확인하는 플래그
    private bool isGrounded;
    // BoxCollider2D 컴포넌트 참조
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        // 필요한 컴포넌트를 가져옴
        _controller = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        // 캐릭터 컨트롤러의 이벤트에 메서드를 연결
        _controller.OnMoveEvent += Move;
        _controller.OnJumpEvent += Jump;
    }

    private void Update()
    {
        // 매 프레임마다 지면에 있는지 확인
        isGrounded = CheckIfGrounded();
    }

    private void FixedUpdate()
    {
        // 물리 업데이트에서 이동 적용
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // 이동 방향 설정, 수평 이동에만 영향을 줌
        _movementDirection = new Vector2(direction.x * moveSpeed, _rigidbody.velocity.y);
    }

    private void Jump()
    {
        // 지면에 있을 때만 점프 실행
        if (isGrounded)
        {
            Debug.Log("Jumping");
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpForce);
        }
    }

    private bool CheckIfGrounded()
    {
        // BoxCast를 사용해 지면 감지
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private void ApplyMovement(Vector2 direction)
    {
        // Rigidbody에 이동 속도 적용
        _rigidbody.velocity = direction;
    }
}




