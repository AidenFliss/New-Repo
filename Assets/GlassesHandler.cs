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

    public void FixGlasses(XRBaseInteractable obj)
    {
        obj.gameObject.layer = 11;
    }

    public void UnFixGlasses(XRBaseInteractable obj)
    {
        obj.gameObject.layer = 0;
    }
}
