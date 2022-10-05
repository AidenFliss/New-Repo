using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DrinkPourer : MonoBehaviour
{
    public float origRate = 20.0f;

    public ParticleSystem particles;
    public XRSocketInteractor socket;

    [SerializeField]
    private bool isGrabbed = false;

    void Update()
    {
        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {
            if (socket.hasSelection == false && isGrabbed == true)
            {
                var em = particles.emission;
                em.rateOverTime = origRate;
            }
        }else
        {
            var em = particles.emission;
            em.rateOverTime = 0f;
        }
    }

    public void SetGrabbed(bool value)
    {
        isGrabbed = value;
    }
}
