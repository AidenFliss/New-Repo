using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DrinkPourer : MonoBehaviour
{
    [Tooltip("The original particle spawn rate of the particle system")]
    public float origRate = 20.0f;

    [Tooltip("The drink effects particles")]
    public ParticleSystem particles;

    [Tooltip("The socket used for the cap")]
    public XRSocketInteractor socket;

    private bool isGrabbed = false;

    void Update()
    {
        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {
            if (socket.gameObject == null && isGrabbed == true)
            {
                var em = particles.emission;
                em.rateOverTime = origRate;
                em.enabled = true;
            }
        }
        else
        {
            var em = particles.emission;
            em.rateOverTime = 0f;
            em.enabled = false;
        }
    }

    public void SetGrabbed(bool value)
    {
        isGrabbed = value;
    }
}
