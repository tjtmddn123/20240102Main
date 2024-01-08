using UnityEngine;
using System.Collections;
//--------------------------------------------------------------------
//When the player enters, respawn them
//--------------------------------------------------------------------
public class DeathTrigger : MonoBehaviour 
{
    public delegate void DeathPanel();
    public static event DeathPanel onPanel;

    void OnTriggerEnter(Collider a_Collider)
    {
        ControlledCapsuleCollider controlledCapsuleCollider = a_Collider.GetComponent<ControlledCapsuleCollider>();
        if (controlledCapsuleCollider != null)
        {
            //Prevent death state to be used if the collider is no-clipping
            if (controlledCapsuleCollider.AreCollisionsActive())
            {
                if (InSceneLevelSwitcher.Get())
                {
                    InSceneLevelSwitcher.Get().Respawn();
                }
                onPanel?.Invoke();
            }
        }
    }
}
