using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Food : MonoBehaviour
{
    [Tooltip("The object that is the first stage")]
    public GameObject foodObjMain;

    [Tooltip("The object that contains all the requirements for food")]
    public GameObject container;

    [Tooltip("The ammount of stages for the object (bites)")]
    public int stages = 3;

    [Tooltip("The number of the inedible stage (-1 for no inedible stage)")]
    public int inedibleStage = -1;
    int currentStg = 0;

    [Tooltip("The audio source used to play the bite sounds")] 
    public AudioSource audioSource;

    [Tooltip("The game objects for all the stages")]
    public List<GameObject> stageObjects = new List<GameObject>();
    [Tooltip("The different sounds used when taking bites of food")]
    public List<AudioClip> soundVariations = new List<AudioClip>();

    [Range(0f, 1f)]
    [Tooltip("The variation of the volume of the audio source")]
    public float volumeVariation = 0f;

    [Tooltip("The particle system for the bite effects")]
    public ParticleSystem biteParticles;

    public void TakeBite()
    {
        if ((currentStg != inedibleStage) || inedibleStage == -1)
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
            }
        }
    }
}
