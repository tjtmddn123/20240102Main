using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner2D : MonoBehaviour
{
    [SerializeField] public Transform[] SpawnPoint;
    [SerializeField] public int shootingForce = 10;
    static TrapSpawner2D a_TrapSpawner2D;
    private TrapPool2D trapPool2D;
    public static TrapSpawner2D Get()
    {
        if (a_TrapSpawner2D == null)
        {
            a_TrapSpawner2D = FindObjectOfType<TrapSpawner2D>();
            if (a_TrapSpawner2D == null)
            {
                return null;
            }
        }
        return a_TrapSpawner2D;
    }
    private void Awake()
    {
        SpawnPoint = GetComponentsInChildren<Transform>();
        trapPool2D = GetComponent<TrapPool2D>();
    }
    public void Shoot(int a_Index)
    {
        GameObject trap = trapPool2D.SpawnFromPool(0);
        trap.transform.position = SpawnPoint[a_Index].position;
        // 발사된 총알에 힘을 가해줌
        Rigidbody2D shootingTrapRb = trap.GetComponent<Rigidbody2D>();
        if (shootingTrapRb != null)
        {
            // Rigidbody의 속도와 각속도 초기화
            shootingTrapRb.velocity = Vector2.zero;
            shootingTrapRb.angularVelocity = 0f;

            // 새로운 힘을 가함
            shootingTrapRb.AddForce(new Vector2(SpawnPoint[a_Index].up.x, SpawnPoint[a_Index].up.y) * shootingForce, ForceMode2D.Impulse);
        }
    }
}
