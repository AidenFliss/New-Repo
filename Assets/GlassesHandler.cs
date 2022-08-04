using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GlassesHandler : MonoBehaviour
{
    public XRSocketInteractor socket;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }
    
    public void FixGlasses()
    {
        IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

        objName.transform.gameObject.layer = 11;
    }

    public void UnFixGlasses()
    {
        IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

        objName.transform.gameObject.layer = 0;
    }
}
