using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStrike : MonoBehaviour
{
    public GameObject PlayerSprite;
    public Sprite NoArmSprite,defaultSprite;
    public GameObject ArmLeft,ArmRight;

    private void Start()
    {
        ArmLeft.SetActive(false);
        ArmRight.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1"))
        {
            Debug.Log("jump or fire1 pressed");
            PlayerSprite.GetComponent<SpriteRenderer>().sprite = NoArmSprite;

            if(PlayerSprite.GetComponent<SpriteRenderer>().flipX)
            {
                ArmRight.SetActive(true);
                ArmRight.GetComponent<Animator>().SetTrigger("start");
            }
            else
            {
                ArmLeft.SetActive(true);
                ArmLeft.GetComponent<Animator>().SetTrigger("start");
            }
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal < -0.01f)
        {
            ArmRight.SetActive(false);
            PlayerSprite.GetComponent<SpriteRenderer>().sprite = defaultSprite;

        }

        if (horizontal > 0.01f)
        {
            ArmLeft.SetActive(false);
            PlayerSprite.GetComponent<SpriteRenderer>().sprite = defaultSprite;

        }

        if (Input.GetButtonUp("Fire1"))
        {
            //if (ArmLeft.GetComponent<Animator>().GetBool("stop") == false)
            //{
            //    //onanimationEnd();
            //}
            //if (ArmRight.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime <= 0)
            //{
            //    onanimationEnd();
            //}

            //if (ArmLeft.GetComponent<Animator>().GetBool("stop"))
            //{
            //    onanimationEnd();
            //} //onanimationEnd();
        }
           
        

        
    }
    private void onanimationEnd()
    {
        PlayerSprite.GetComponent<SpriteRenderer>().sprite = defaultSprite;
        ArmRight.SetActive(false);
        ArmLeft.SetActive(false);
    }
}
