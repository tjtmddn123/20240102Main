using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckShootTrap2D : MonoBehaviour
{
    [SerializeField] int m_Index;
    private Coroutine shootingCoroutine;

    void OnTriggerEnter2D(Collider2D other)
    {
        // 다른 오브젝트와 충돌 시 코루틴 시작
        if (other.CompareTag("Player"))
        {
            shootingCoroutine = StartCoroutine(StartShooting());
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // 다른 오브젝트와 충돌이 끝날 때 코루틴 중지
        if (other.CompareTag("Player") && shootingCoroutine != null)
        {
            StopCoroutine(shootingCoroutine);
        }
    }

    IEnumerator StartShooting()
    {
        while (true)
        {
            if (TrapSpawner.Get())
            {
                TrapSpawner2D.Get().Shoot(m_Index);
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
