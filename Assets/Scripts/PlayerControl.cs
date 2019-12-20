using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float movSPD = 1.3f;
    public Animator animator;
    private bool isFlipped = false;

    void FixedUpdate()
    {
        Movement();
    }


    void Movement()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            gameObject.transform.Translate(0.1f * movSPD, 0, 0);  //move o player para a esquerda
            animator.SetFloat("Speed", 1.5f);

            if (!isFlipped)
            {
                transform.Rotate(0f, 180f, 0f);
                isFlipped = true;
            }
            
            

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            gameObject.transform.Translate(0.1f * movSPD, 0, 0); // move o player para a direita
            animator.SetFloat("Speed", 1.5f);
            if (isFlipped)
            {
                transform.Rotate(0f, -180f, 0f);
                isFlipped = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {

            animator.SetFloat("Speed", 0f);
        }
    }
}