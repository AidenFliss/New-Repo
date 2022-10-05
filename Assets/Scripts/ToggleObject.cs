using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject gameObjectO;
    
    void Awake()
    {
        gameObjectO = transform.gameObject;
    }

    public void ToggleVisible()
    {
        bool state = !gameObjectO.activeSelf;
        gameObjectO.SetActive(state);
    }
}
