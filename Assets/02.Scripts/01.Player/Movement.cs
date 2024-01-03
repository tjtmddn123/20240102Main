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
    [SerializeField] private bool isGrounded;
    // BoxCollider2D 컴포넌트 참조
    private BoxCollider2D boxCollider;

    private bool isInputBlocked = false;

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
        // 지면에 있는지 여부를 갱신
        isGrounded = CheckIfGrounded();

        // 키 입력이 차단된 상태에서 지면에 닿으면 키 입력을 다시 활성화
        if (isGrounded && isInputBlocked)
        {
            isInputBlocked = false;
        }
    }

    private void FixedUpdate()
    {
        // 키 입력이 차단되지 않았으면 이동 적용
        if (!isInputBlocked)
        {
            ApplyMovement(_movementDirection);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 게임 오브젝트가 "HideTrap" 태그를 가지고 있는지 확인
        if (collision.gameObject.CompareTag("HideTrap"))
        {
            Vector2 normal = collision.contacts[0].normal;
            // 좌우측 충돌 감지 시 키 입력 차단
            if (Mathf.Abs(normal.y) < Mathf.Abs(normal.x))
            {
                isInputBlocked = true;
            }
        }
    }

    private void Move(Vector2 direction)
    {
        // 키 입력이 차단되지 않았으면 이동 방향 설정
        if (!isInputBlocked)
        {
            _movementDirection = new Vector2(direction.x * moveSpeed, _rigidbody.velocity.y);
        }
    }

    public void Jump()
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
        // BoxCast를 사용해 지면에 닿았는지 확인
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, 0.1f, groundLayer);
        return (raycastHit.collider != null);
    }


    private void ApplyMovement(Vector2 direction)
    {
        // Rigidbody에 새로운 속도(수평 이동과 기존의 수직 속도)를 적용
        _rigidbody.velocity = new Vector2(direction.x, _rigidbody.velocity.y);
    }
}






