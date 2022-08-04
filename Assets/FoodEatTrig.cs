using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEatTrig : MonoBehaviour
{
    public BoxCollider boxCollider;
    bool cooldown = false;
    Food foodScr;

    void Awake()
    {
        boxCollider = GetComponent< BoxCollider >();
    }

    void OnTriggerEnter(Collider obj)
    {
        Debug.Log("unknown obj touch");
        Debug.Log("obj name: " + obj.gameObject.name);
        if (obj.gameObject.tag == "Food" && cooldown == false)
        {
            Debug.Log("object identified!");
            foodScr = obj.gameObject.GetComponent< Food >();
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
