using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OnHoverObject : MonoBehaviour
{
    public static void HoverEnterObj(IXRHoverInteractor interactor, IXRHoverInteractable interactable, BaseInteractionEventArgs args)
    {
        GameObject hoveredObject = args.interactableObject.transform.gameObject;
        Renderer rend = hoveredObject.GetComponent<Renderer>();
        Material mat = rend.material;
        mat.color = Color.yellow;
    }

    public static void HoverExitObj(IXRHoverInteractor interactor, IXRHoverInteractable interactable, BaseInteractionEventArgs args)
    {
        GameObject unhoveredObject = args.interactableObject.transform.gameObject;
        Renderer rend = unhoveredObject.GetComponent<Renderer>();
        Material mat = rend.material;
        mat.color = Color.white;
    }
}
