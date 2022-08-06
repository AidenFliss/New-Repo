using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DrinkPourer : MonoBehaviour
{
    public bool infinite = true;
    public float rotThreshhold = 120;

    public float origRate = 20.0f;

    public ParticleSystem particles;
    public XRSocketInteractor socket;

    void Update()
    {
        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {
            if (socket.hasSelection == false)
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
}
