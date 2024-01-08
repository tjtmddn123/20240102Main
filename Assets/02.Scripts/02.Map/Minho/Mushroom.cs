using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mushroom : MonoBehaviour
{
    float rightMax;
    float leftMax;
    float currentPos;
    float dir = 1f;

    private void Start()
    {
        rightMax = transform.position.x + 5f;
        leftMax = transform.position.x - 5f;
        currentPos = transform.position.x;
    }

    private void Update()
    {
        currentPos += Time.deltaTime * dir;
        if (currentPos >= rightMax)
        {
            dir *= -1f;
            currentPos = rightMax;
        }
        else if (currentPos <= leftMax)
        {
            dir *= -1f;
            currentPos = leftMax;
        }

        transform.position = new Vector2(currentPos, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            StartCoroutine("MushroomTouch");
    }

    IEnumerator MushroomTouch()
    {
        Time.timeScale = 0;
        transform.localScale = new Vector2(3f, 3f);
        transform.position = new Vector3(transform.position.x, -1.53f, 0f);
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
