using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class ButtonActivation : MonoBehaviour
{
    public Image uiImage;
    public Sprite onSprite;
    public Sprite offSprite;
    public GameObject disappearGround;
    bool isOn;


    private void Start()
    {
        isOn = false;
    }
    void OnTriggerEnter(Collider a_Collider)
    {

        if (!isOn)
        {
            disappearGround.SetActive(false);
            uiImage.sprite = onSprite;
            isOn = true;
        }
        else if (isOn)
        {
            disappearGround.SetActive(true);
            uiImage.sprite = offSprite;
            isOn = false;
        }
    }
}
