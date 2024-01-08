# 냥코의 모험!!

한마리의 고양의 모험! 각종 함정과 장애물을 피하며 최종 지점까지 도달하는 게임! 

# 장르
액션 게임

# 참고 자료
## 1.링크 
https://namu.wiki/w/%EC%87%BC%EB%B3%B8%EC%9D%98%20%EC%95%A1%EC%85%98?from=%EA%B3%A0%EC%96%91%EC%9D%B4%20%EB%A7%88%EB%A6%AC%EC%98%A4

링크 : ![rhdiddl](https://github.com/tjtmddn123/20240102Main/assets/150320634/81abf72a-3f3a-443e-a358-8401146202c1)

(고양이 마리오)

# 필수 구현 요구 사항
1. **인공 캐릭터의 이동 및 기본 동작:**
    - 키보드 또는 터치 입력을 통해 주인공 캐릭터를 움직이고, 점프할 수 있어야 합니다.
    - 이동 및 점프 애니메이션을 포함하여 부드러운 이동 효과를 구현하세요.
2. **레벨 디자인 및 적절한 게임 오브젝트 배치:**
    - 최소한 2개 이상의 게임 레벨을 디자인하고 구현하세요.
    - 각 레벨에는 적절한 플랫폼, 장애물, 보상 아이템 등이 포함되어야 합니다.
3. **충돌 처리 및 피해량 계산:**
    - 주인공 캐릭터와 환경 또는 적 캐릭터 사이의 충돌을 처리하고, 피해량을 계산하여 게임 내에서 적절한 게임 오브젝트를 활용하세요.
4. **UI/UX 요소:**
    - 게임 시작 및 일시 정지 메뉴를 구현하세요.
    - 점수 표시, 생명력 게이지, 레벨 진행 상황 등 게임 상태를 나타내는 UI 요소를 추가하세요.
5. **추가 구현 사항 중 선택하여 3가지 이상 구현:**
    - 다양한 구현을 도전해 보세요.

# S.A (Starting Assignments)
<img width="674" alt="스크린샷 2024-01-08 212119" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/f7bff696-878f-4d3f-b0ce-24c9103e1eb0">

링크: https://www.figma.com/file/cbq4cPGt0aCwKs33xz22qD/10%EC%A1%B0?type=whiteboard&node-id=0-1&t=lOj9TMR1wkZOTFQ3-0

# 역할 분배
|이름|역할|
|------|---|
|서승우(팀장)|인트로, 엔딩, 맵 제작|
|박민규(발표)|튜토리얼, 맵 제작|
|이민호|맵 제작 X2|
|이철희|맵 제작|
|장영준|맵 제작|

# 맵 사진

## 1. 인트로 (서승우)
<img width="573" alt="스크린샷 2024-01-08 211013" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/93047be8-ccdc-426e-96c7-b4a15d53c106">

## 2. 튜토리얼 (박민규)
<img width="746" alt="스크린샷 2024-01-08 210914" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/20673c1d-9398-4a32-8330-9b1b6f66a125">

## 3. 이민호(1) 맵
<img width="1146" alt="스크린샷 2024-01-08 210945" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/b69cfde4-97fb-4d3f-8feb-6262d3f12137">

## 4. 이민호(2) 맵
<img width="1143" alt="스크린샷 2024-01-08 211001" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/96167f10-8628-4708-af8d-638cc6abd9d3">

## 5. 이철희 맵
<img width="340" alt="스크린샷 2024-01-08 210856" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/14e694ad-a40b-48a7-9a41-962f490baf5c">

## 6. 서승우 맵
<img width="1158" alt="스크린샷 2024-01-08 210813" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/f9609ee9-94cf-465b-a731-cc5c42d46bdf">

## 7. 장영준 맵
<img width="875" alt="스크린샷 2024-01-08 210838" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/3adc7c39-603e-4705-80d4-8a60c8d452cb">

## 8. 박민규 맵
<img width="926" alt="스크린샷 2024-01-08 210928" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/2157d626-cc0a-4bd6-aed0-74b55cc8be42">

## 9. 엔딩 (서승우)
<img width="613" alt="스크린샷 2024-01-08 211019" src="https://github.com/tjtmddn123/20240102Main/assets/150320634/cdc342da-0777-4264-b9da-4334b37796cf">

# 트러블 슈팅

**서승우**

1. 플레이어 점프가 되지 않는 현상이 발생 이유는 초기 코드 메서드에서 Rigidbody2D의 velocity를 설정할 때 수평 방향만 고려, 수직 속도는 무시해서 버려서 발생한 문제였습니다.
  - 해결책으로는 메서드 내에서 Rigidbody2D의 현재 velocity.y 값을 유지하는 것으로 해결했습니다.
  - 이동발판을 구현하는 도중 Rigidbody2D 컴포넌트를 추가하고, 특정 경로를 따라 이동하도록 스크립트를 작성 하였고 특정경로를 지정하는 Point가 발판과 함께 이동하는 현상이 발생.
  - 이건 아주 황당하게도 Point를 이동발판에 상속을 시켜버려서 발생한 문제였습니다. 본인은 스크립트 문제인 줄 알고 이걸로 3시간 날려먹었습니다.

**박민규**

1. DoTween을 사용하는데 Sequence설정중에 Append 로 기준을 안잡아주고 Join만을 써서 AppendInterval이 합쳐지는 오류가 발생함
  - 해결방법 - Join으로 썼던 Tween을 Append로 만들어주어 AppendInterval 사이에 Apped를 사용하여 기준점을 생성해주니 원하는 대로 Interval이 발생함.
2. DoTween으로 함정을 만들 때 Scale과 Transform값을 바꿀 때 중간에 게임오브젝트를 Active(false)를 하니, 함정의 초기 위치랑 달라지는 현상이 발생
  - 해결방법 - cs파일의 OnDisable에 오브젝트의 초기값을 저장한 변수를 다시 넣어줌으로, 오브젝트를 껐을 때 초기위치로 다시 가도록 설정

**이민호**

1. 캐릭터 벽에 달라붙는 현상
  - 2D Material을 생성하여 Friction을 0으로 만들어 해결
2. 타일맵 사이간격에 끼이는 현상
  - Tilemap Collider2D에 Used By Composite 사용 후 Composite Collider 추가하여 해결

**이철희**

1. 플레이어 점프 안되는 현상
  - ground, player 레이블을 정확히 입력해주니 해결됐습니다.
2. 플레이어 벽에 달라붙음 현상
  - 플레이어 rigidbody의 material 설정을 해줬습니다.

**장영준**

트러블: 오브젝트 풀링을 구현하는 데 있어서 오브젝트가 너무 많이 나가거나 렉이 걸릴 정도로 풀링 되거나 이상한 위치에서 나가는 등의 현상이 있었습니다.
1.오브젝트 풀링 구현 문제
 - 코루틴을 이용하여 Trap 오브젝트의 SetActive가 2초뒤에 False가 되도록 하였다.
2. Trap이 엉뚱한 곳에 소환 됨.
- 소환 위치를 초기화해줌.
3. Trap이 너무 많이 소환이 멈추지 않음.
- 코루틴을 이용하여 collider를 나갔을 경우 소환이 멈추도록 함.
4. Trap 오브젝트가 점점 빨라짐.
- 오브젝트의 SetActive가 False가 되어도 이전에 RigidBody에 AddForce를 통해 주었던 힘이 그대로 남아 있기 때문에 재활용 할 때 더욱 빨라지는 문제가 발생함.
- 그래서 재활용 할 때 RigidBody의 Velocity와 angularVelocity를 초기화 해줌.

