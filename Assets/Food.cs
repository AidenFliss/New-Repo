using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Food : MonoBehaviour
{
    public GameObject foodObjMain;
    public GameObject container;

    public int stages = 3;

    public AudioSource audioSource;

    //public List<int> edibleStages = new List<int>();
    public List<GameObject> stageObjects = new List<GameObject>();
    public List<AudioClip> soundVariations = new List<AudioClip>();

    [Range(0f, 1f)]
    public float volumeVariation = 0f;

    public ParticleSystem biteParticles;

    public void TakeBite()
    {
        stages--;
        biteParticles.Emit(7);
        audioSource.PlayOneShot(soundVariations[UnityEngine.Random.Range(0, soundVariations.Count)], UnityEngine.Random.Range(0f, volumeVariation));
        if (stages <= 0)
        {
            Destroy(container);
        }else
        {
            foodObjMain.SetActive(false);
            if (stages >= 1)
            {
                stageObjects[stages - 1].SetActive(false);
            }
            stageObjects[stages].SetActive(true);
        }
    }
}
