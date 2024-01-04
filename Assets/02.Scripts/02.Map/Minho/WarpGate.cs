using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpGate : MonoBehaviour
{
    bool playerOnWarpGate = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerOnWarpGate = true;
            StartCoroutine("Warp");
        }
        else
        {
            StopCoroutine("Warp");
            playerOnWarpGate = false;
        }
    }

    IEnumerator Warp()
    {
        while (playerOnWarpGate)
        {
            yield return null;

            if (Input.GetKeyDown(KeyCode.S))
            {
                SceneManager.LoadScene("05.MH-Map2");
            }
        }
    }
}
