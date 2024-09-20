using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSounds : MonoBehaviour
{
    public AudioSource audioSource;

    [Header ("Sounds")]
    public AudioClip MenuMove;
    public AudioClip Select;


    public void playSoundMenuMove()
    {
        audioSource.clip = MenuMove;
        audioSource.Play();
    }
    public void playSoundSelect()
    {
        audioSource.clip = Select;
        audioSource.Play();
    }
}
