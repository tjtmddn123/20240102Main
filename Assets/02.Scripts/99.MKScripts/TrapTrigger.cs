using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject targetTrap;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (targetTrap) // 게임 오브젝트를 파괴했는데 리로드를 안하면 null일수 있으니 이렇게 짰음. 만약 씬리로드를 안한다하면 바꿔주면됌.
            {
                targetTrap.SetActive(true);
            }
        }
    }
}
