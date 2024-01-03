using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishEffect : MonoBehaviour
{
    private Transform playerChildTransform;
    private float rotationSpeed;
    private float rotationSpeedIncreaseRate = 500f; // 점점 증가시켜주고싶기 때문에 float로 된 증가값 하나 더 넣어줌.
    private bool isFinish = false;

    private float scaleSpeed = 0.1f;

    void Awake()
    {
        playerChildTransform = transform.Find("MainSprite");
    }

    void Update()
    {
        if (isFinish)
        {
            ScaleObject();
            UIManager.Instance.fadeInAndOutUi.SetBool("IsFinish", true);
            //Invoke로 1초 지연줘서 씬체인지하면 매끄럽게 됨.
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            isFinish = true;
        }
    }

    private void RotateObject()
    {
        playerChildTransform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    void ScaleObject()
    {
        if (playerChildTransform.localScale.x > 0.01f)
        {
            playerChildTransform.localScale -= new Vector3(scaleSpeed, scaleSpeed, 0f) * Time.deltaTime;
            rotationSpeed += rotationSpeedIncreaseRate * Time.deltaTime;
            RotateObject();
        }
    }
}
