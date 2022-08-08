using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OnHoverObject : MonoBehaviour
{
    public static void HoverEnterObj(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverEnterEventArgs args)
    {
        GameObject hoveredObject = args.interactable.gameObject;
        Renderer rend = hoveredObject.GetComponent<Renderer>();
        Material mat = rend.material;
        mat.color = Color.yellow;
    }

    public static void HoverExitObj(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverExitEventArgs args)
    {
        GameObject unhoveredObject = args.interactable.gameObject;
        Renderer rend = unhoveredObject.GetComponent<Renderer>();
        Material mat = rend.material;
        mat.color = Color.white;
    }
}
