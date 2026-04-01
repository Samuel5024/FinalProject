using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private void Awake() 
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }
   
    void Start()
    {
        grabInteractable.activated.AddListener(Shoot);
    }

    private void Shoot(ActivateEventArgs arg0)
    {
        Debug.Log("Bang!");
    }

    private void OnDestroy()
    {
        grabInteractable.activated.RemoveListener(Shoot);
    }
}
