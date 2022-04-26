using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ImageRewardButtons : MonoBehaviour
{

    AudioSource source;
    public AudioClip[] popSounds;

    private void Start()
    {
         source = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        transform.DOScale(1.2f, 0.1f).OnComplete(() => transform.DOScale(0, 0.3f));
        PlaySound();
    }

    void PlaySound()
    {
        int randomSound = Random.Range(0, popSounds.Length);

        source.PlayOneShot(popSounds[randomSound]);
    }
}
