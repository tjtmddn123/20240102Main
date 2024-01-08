using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingFalse : MonoBehaviour
{
    static ShootingFalse shootingFalse;
    public static ShootingFalse Get()
    {
        if (shootingFalse == null)
        {
            shootingFalse = FindObjectOfType<ShootingFalse>();
            if (shootingFalse == null)
            {
                return null;
            }
        }
        return shootingFalse;
    }
    public void DoFalse()
    {
        gameObject.SetActive(false);
    }
}
