using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    [SerializeField] public Transform[] SpawnPoint;
    [SerializeField] public int shootingForce = 10;
    static TrapSpawner a_TrapSpawner;
    private TrapPool trapPool;
    int current_Index;
    public static TrapSpawner Get()
    {
        if (a_TrapSpawner == null)
        {
            a_TrapSpawner = FindObjectOfType<TrapSpawner>();
            if (a_TrapSpawner == null)
            {
                return null;
            }
        }
        return a_TrapSpawner;
    }
    private void Awake()
    {
        SpawnPoint = GetComponentsInChildren<Transform>();
        trapPool = GetComponent<TrapPool>();
    }
    public void Shoot(int a_Index)
    {
        GameObject trap = trapPool.SpawnFromPool(0);
        trap.transform.position = SpawnPoint[a_Index].position;
        // 발사된 총알에 힘을 가해줌
        Rigidbody shootingTrapRb = trap.GetComponent<Rigidbody>();
        if (shootingTrapRb != null)
        {
            // Rigidbody의 속도와 각속도 초기화
            shootingTrapRb.velocity = Vector3.zero;
            shootingTrapRb.angularVelocity = Vector3.zero;

            // 새로운 힘을 가함
            shootingTrapRb.AddForce(SpawnPoint[a_Index].up * shootingForce, ForceMode.Impulse);
        }
    }
}
