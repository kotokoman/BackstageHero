using UnityEngine;

public class NotesPlay : MonoBehaviour
{
    public AudioClip error;
    public AudioSource MusicSource;
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "PlayLine")
        {
            Destroy(gameObject);
        }

        if(c.gameObject.tag == "Player")
        {
            MusicSource.PlayOneShot(error, 1f);
            Destroy(gameObject);
        }
    }
}
