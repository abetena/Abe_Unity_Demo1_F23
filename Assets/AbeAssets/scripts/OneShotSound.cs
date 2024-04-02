using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSound : MonoBehaviour
{
    // The audio we will play
    public AudioClip explosion;

    //Audio Source
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //Get the audio source
        audioSource = GetComponent<AudioSource>();

    }

    //accessible as a custom action
    public void playOneShot()
    {
        //play the sound
        audioSource.PlayOneShot(explosion, 1.0f);
    }
}
