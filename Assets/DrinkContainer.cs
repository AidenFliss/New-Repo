using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkContainer : MonoBehaviour
{
    [Header("Drink Vars")]

    public float maxHeight = 5f;
    public float minHeight = 0f;

    [Range(0.0f, 1.0f)]
    public float drinkAmnt = 0f;

    [Space]

    [Header("References")]
    public Transform drinkPlane;
    public Transform drinkContainer;
    public ParticleSystem particles;

    public float drinkCooldown = 0.05f;

    public void UpdatePlane()
    {
        drinkPlane.position = new Vector3(drinkPlane.position.x, (maxHeight - minHeight) * drinkAmnt / 2 + minHeight, drinkPlane.position.z);
        drinkPlane.rotation = Quaternion.Euler(0, 0, drinkContainer.rotation.eulerAngles.z);
    }

    public void AddDrink(float amount)
    {
        drinkAmnt += amount;
        UpdatePlane();
    }

    public void RemoveDrink(float amount)
    {
        drinkAmnt -= amount;
        UpdatePlane();
    }

    public void SetDrink(float amount)
    {
        drinkAmnt = amount;
        UpdatePlane();
    }

    void Update()
    {
        UpdatePlane();
        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {
            if (drinkAmnt > 0)
            {
                //particles.transform.position = drinkPlane.position;
                //particles.transform.rotation = drinkPlane.rotation;
                //particles.gameObject.SetActive(true);
                StartCoroutine(WaitForSeconds(drinkCooldown));
            }
        }else
        {
            //particles.gameObject.SetActive(false);
        }
    }

    IEnumerator WaitForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        RemoveDrink(0.01f);
    }
}
