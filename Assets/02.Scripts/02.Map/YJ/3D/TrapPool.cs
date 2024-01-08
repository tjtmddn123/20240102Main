using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TrapPool : MonoBehaviour
{
    public GameObject[] prefeb;
    public List<GameObject>[] pools;
    CheckShootTrap checkShootTrap;
    private Coroutine deactivateCoroutine;

    private void Awake()
    {
        pools = new List<GameObject>[prefeb.Length];

        for (int index = 0; index < pools.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }

    }
    private void Start()
    {
        checkShootTrap = GetComponent<CheckShootTrap>();
    }
    public GameObject SpawnFromPool(int index)
    {
        GameObject select = null;
        foreach (GameObject pool in pools[index])
        {
            if (!pool.activeSelf)
            {
                select = pool;
                select.SetActive(true);
                StartCoroutine(DeactivateTrapAfterDelay(select, 2f));
                break;
            }
        }
        if (!select)
        {
            select = Instantiate(prefeb[index], transform);
            pools[index].Add(select);
            StartCoroutine(DeactivateTrapAfterDelay(select, 2f));
        }
        
        return select;
    }
    IEnumerator DeactivateTrapAfterDelay(GameObject select, float delay)
    {
        yield return new WaitForSeconds(delay);
        
        select.SetActive(false);
    }
}
