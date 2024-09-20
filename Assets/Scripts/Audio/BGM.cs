using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource audioSource;

    [Header("Sounds")]
    public AudioClip[] Music;

    private int index = 0;  //used for traversing array of music

    // Start is called before the first frame update
    void Start()
    {
        Shuffle();
    }

    // Update is called once per frame
    void Update()
    {
        //skip track
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            index++;
            audioSource.clip = Music[index];
            audioSource.Play();
        }

        //shuffle playlist when all tracks are played
        if(index == Music.Length)
        {
            Shuffle();
        }

        if (!audioSource.isPlaying)
        {
            audioSource.clip = Music[index];
            audioSource.Play();
            index++;
        }
    }

    //shuffle tracks
    void Shuffle()
    {
        for (int i = Music.Length - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            AudioClip temp = Music[i];
            Music[i] = Music[j];
            Music[j] = temp;
        }
    }
}
