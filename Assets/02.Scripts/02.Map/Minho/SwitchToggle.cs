using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] private GameObject switchBlock;

    int toggle = -1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (toggle < 0)
            {
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(false);
                switchBlock.gameObject.SetActive(true);
                toggle *= -1;
            }
            else if (toggle > 0)
            {
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
                switchBlock.gameObject.SetActive(false);
                toggle *= -1;
            }
        }
    }
}
