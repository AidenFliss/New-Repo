using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkPourer : MonoBehaviour
{
    public bool infinite = true;
    public float rotThreshhold = 120;

    public float origRate = 20.0f;

    public ParticleSystem particles;

    void Update()
    {
        if ((transform.rotation.z >= rotThreshhold && transform.rotation.z < 240) || (transform.rotation.x >= rotThreshhold && transform.rotation.x < 240))// || (transform.rotation.z <= rotThreshhold && transform.rotation > )) //note to future self: loook up checking if angles do thnig or whatavr (or if up is down)
        {
            Debug.Log("e passes");
            var em = particles.emission;
            em.rateOverTime = origRate;
        }else
        {
            Debug.Log("no passe :(");
            var em = particles.emission;
            em.rateOverTime = 0f;
        }
    }
}
