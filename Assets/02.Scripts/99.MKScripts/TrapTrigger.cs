using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject[] targetTrap;
    public GameObject deactiveTarget;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (targetTrap != null)
            {
                foreach (GameObject trap in targetTrap)
                {
                    if (trap != null)
                    {
                        trap.SetActive(true);
                    }
                }
            }
            if (deactiveTarget != null)
            {
                deactiveTarget.SetActive(false);
            }
        }
    }
}
