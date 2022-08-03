using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GlassesHandler : MonoBehaviour
{
    public XRSocketInteractor socket;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void FixGlasses(XRBaseInteractable obj)
    {
        obj.gameObject.layer = 11;
    }

    public void UnFixGlasses(XRBaseInteractable obj)
    {
        obj.gameObject.layer = 0;
    }
}
