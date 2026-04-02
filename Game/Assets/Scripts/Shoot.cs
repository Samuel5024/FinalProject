using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    private void Awake() 
    {
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
    }
   
    void Start()
    {
        grabInteractable.activated.AddListener(Fire);
    }

    private void Fire(ActivateEventArgs arg0)
    {
        Debug.Log("Bang!");
    }

    private void OnDestroy()
    {
        grabInteractable.activated.RemoveListener(Fire);
    }
}
