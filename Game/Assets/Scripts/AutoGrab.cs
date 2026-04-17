using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class AutoGrab : MonoBehaviour
{
    public XRInteractionManager interactionManager;
    public XRGrabInteractable objectToGrab; // item to be grabbed
    public XRBaseInputInteractor handInteractor; // the hand (direct or ray interactor)
    
    void Start()
    {
        if(interactionManager != null && objectToGrab != null && handInteractor != null)
        {
            // force interactino manager to make the interactor select the object
            interactionManager.SelectEnter((IXRSelectInteractor)handInteractor, (IXRSelectInteractable)objectToGrab);
        }
    } 
}
