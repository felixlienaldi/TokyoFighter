using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Character player = new Character();
    public GameObject melee;
    public float cooldown;
    public bool canAttack;
    bool facingRight;
    Animator anim;

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
        if (canAttack)
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



    }

    public void ButtonRightPunch()
    {
        if (canAttack)
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
        
    

    }

    public void ButtonLeft()
    {
        if (canAttack)
        {
            if (!facingRight && canAttack)
            {
                //Insert Punch Script Here
                anim.SetBool("kick", true);

            }
            else if (facingRight && canAttack)
            {
                Flip();
                facingRight = false;
                //Insert Punch Script Here
                anim.SetBool("kick", true);

            }

            StartCoroutine(waitAnimation());
        }
       

    }

    public void ButtonLeftPunch()
    {
        if (canAttack)
        {

            if (!facingRight && canAttack)
            {
                anim.SetBool("punch", true);

            }
            else if (facingRight && canAttack)
            {
                Flip();
                facingRight = false;
                //Insert Punch Script Here
                anim.SetBool("punch", true);

            }

            StartCoroutine(waitAnimation());
        }

    }

    void Flip()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);
    }

    IEnumerator waitAnimation()
    {
        canAttack = false;
        yield return new WaitForSeconds(0.4f);
        melee.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        anim.SetBool("kick", false);
        anim.SetBool("punch", false);
        melee.SetActive(false);
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
    }
}
