using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "PlayLine")
        {
            FindObjectOfType<SceneManagement>().FinishGame();
        }
    }
}
