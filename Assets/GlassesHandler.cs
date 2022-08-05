using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GlassesHandler : MonoBehaviour
{
    public XRSocketInteractor socket;

    void Awake()
    {
        socket = GetComponent<XRSocketInteractor>();
        socket.onSelectEnter.AddListener(FixGlasses);
        socket.onSelectExit.AddListener(UnFixGlasses);
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
