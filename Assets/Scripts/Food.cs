using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Food : MonoBehaviour
{
    public GameObject foodObjMain;
    public GameObject container;

    public BoxCollider collision;

    public int stages = 3;
    int currentStg = 0;

    public AudioSource audioSource;

    //public List<int> edibleStages = new List<int>();
    public List<GameObject> stageObjects = new List<GameObject>();
    public List<AudioClip> soundVariations = new List<AudioClip>();

    [Range(0f, 1f)]
    public float volumeVariation = 0f;

    public ParticleSystem biteParticles;

    void Awake()
    {
        collision = GetComponent<BoxCollider>();
    }

    public void TakeBite()
    {
        currentStg++;
        biteParticles.Emit(7);
        audioSource.PlayOneShot(soundVariations[UnityEngine.Random.Range(0, soundVariations.Count)], UnityEngine.Random.Range(0f, volumeVariation));
        if (currentStg >= stages)
        {
            Destroy(container);
        }else
        {
            foodObjMain.SetActive(false);
            if (currentStg >= 1)
            {
                stageObjects[currentStg - 1].SetActive(false);
            }
            stageObjects[currentStg].SetActive(true);
            collision.size = stageObjects[currentStg].transform.localScale;
        }
    }
}
