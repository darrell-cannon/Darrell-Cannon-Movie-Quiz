using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizAudio : MonoBehaviour
{
    AudioSource source;
    public AudioClip[] correctSounds;
    public AudioClip[] errorSounds;
    
    // Start is called before the first frame update
    void Start()
    {
        QuizManager.OnCorrectAnswer += PlayCorrectSound;
        QuizManager.OnInCorrectAnswer += PlayIncorrectSound;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayCorrectSound()
    {
        int randomSound = Random.Range(0, errorSounds.Length);

        source.PlayOneShot(correctSounds[randomSound]);
    }
    void PlayIncorrectSound()
    {
        int randomSound = Random.Range(0, errorSounds.Length);
        
        source.PlayOneShot(errorSounds[randomSound]);
    }
}
