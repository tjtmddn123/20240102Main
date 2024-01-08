using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFlat : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine(DeactivateSelf());
    }

    IEnumerator DeactivateSelf()
    {
        // 2초 대기
        yield return new WaitForSeconds(2f);

        // 2초 후에 자기 자신을 다시 비활성화
        gameObject.SetActive(false);
    }
}