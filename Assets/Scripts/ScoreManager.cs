using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int maxnote;
    private int notecount = 0;
    public TextMeshProUGUI scoreText;


    private void Awake()
    {
        scoreText = GameObject.Find("Points").GetComponent<TextMeshProUGUI>();
        maxnote = GameObject.FindGameObjectsWithTag("Notes").Length;

    }

    private void Update()
    {
        scoreText.text = notecount.ToString() + " / " + maxnote.ToString();
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Notes")
        {
            notecount++;
        }
    }
}