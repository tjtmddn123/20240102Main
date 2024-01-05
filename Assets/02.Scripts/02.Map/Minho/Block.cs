using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    SpriteRenderer _rend;
    private float colorTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _rend = collision.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
            StartCoroutine("BlockTouch");
        }  
    }

    IEnumerator BlockTouch()
    {
        colorTime = 0;

        Time.timeScale = 0;
        while (colorTime <= 0.1f)
        {
            colorTime += Time.unscaledDeltaTime;
            ChangeColor();
            yield return new WaitForSecondsRealtime(0.05f);
        }
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ChangeColor()
    {
        _rend.color = new Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f);
    }
}
