using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEatTrig : MonoBehaviour
{
    [Tooltip("The collider used to trigger the food bite")]
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
            EatDo(obj);
        }
    }

    void OnTriggerStay(Collider obj)
    {
        if (obj.gameObject.tag == "Food" && cooldown == false)
        {
            EatDo(obj);
        }
    }

    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        cooldown = false;
    }

    public void EatDo(Collider obj)
    {
        cooldown = true;
        Food foodScr = obj.gameObject.GetComponent<Food>();
        foodScr.TakeBite();
        StartCoroutine(DelayAction(0.6f));
    }
}
