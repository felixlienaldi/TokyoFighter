using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Character player = new Character();
    public GameObject melee;
    Animator anim;
    bool facingRight;
   
    
    void Start() {
        player.health = 100f;
        player.stamina = 100f;
        facingRight = true;
        anim = GetComponent<Animator>();
    }

    void Update() {
    
    }

    public void ButtonRight()
    {
        if (facingRight)
            {
                anim.SetBool("kick", true);
               

            }
            else if (!facingRight)
            {
                Flip();
                facingRight = true;
                //Insert Punch Script Here
                anim.SetBool("kick", true);
                
            }

        StartCoroutine(waitAnimation());

    }

    public void ButtonRightPunch()
    {
        if (facingRight)
        {
            anim.SetBool("punch", true);


        }
        else if (!facingRight)
        {
            Flip();
            facingRight = true;
            //Insert Punch Script Here
            anim.SetBool("punch", true);

        }

        StartCoroutine(waitAnimation());

    }

    public void ButtonLeft()
    {
        
            if (!facingRight)
            {
                //Insert Punch Script Here
                anim.SetBool("kick", true);
               
            }
            else if (facingRight)
            {
                Flip();
                facingRight = false;
                //Insert Punch Script Here
                anim.SetBool("kick", true);
             
            }

        StartCoroutine(waitAnimation());

    }

    public void ButtonLeftPunch()
    {
        if (!facingRight)
        {
            anim.SetBool("punch", true);


        }
        else if (facingRight)
        {
            Flip();
            facingRight = false;
            //Insert Punch Script Here
            anim.SetBool("punch", true);

        }

        StartCoroutine(waitAnimation());

    }

    void Flip()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);
    }

    IEnumerator waitAnimation()
    {
        yield return new WaitForSeconds(0.4f);
        melee.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        anim.SetBool("kick", false);
        anim.SetBool("punch", false);
        melee.SetActive(false);
    }
}
