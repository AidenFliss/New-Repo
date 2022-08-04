using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEatTrig : MonoBehaviour
{
    public BoxCollider boxCollider;
    bool cooldown = false;

    void Awake()
    {
        boxCollider = GetComponent< BoxCollider >();
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Food" && cooldown == false)
        {
            Food foodScr = obj.gameObject.GetComponent< Food >();
            foodScr.TakeBite();
            cooldown = true;
            DelayAction(0.3f);
        }
    }

    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        cooldown = false;
    }
}
