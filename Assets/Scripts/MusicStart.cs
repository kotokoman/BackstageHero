using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    public AudioClip Music;
    public AudioSource MusicSource;

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "PlayLine")
        {
            MusicSource.Play();
        }
    }
}
