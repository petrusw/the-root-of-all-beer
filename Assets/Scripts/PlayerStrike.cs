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
                Invoke("endtriggerRight", 0.01f);
                ArmRight.GetComponent<BoxCollider2D>().enabled = true;
            }
            else
            {
                ArmLeft.SetActive(true);
                ArmLeft.GetComponent<Animator>().SetTrigger("start");
                Invoke("endTriggerLeft", 0.01f);
                ArmLeft.GetComponent<BoxCollider2D>().enabled = true;

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

     
           
        

        
    }

    private void endTriggerLeft()
    {
        ArmLeft.GetComponent<Animator>().SetTrigger("stop");
    }
    private void endtriggerRight()
    {
        ArmRight.GetComponent<Animator>().SetTrigger("stop");
    }

    private void onanimationEnd()
    {
        PlayerSprite.GetComponent<SpriteRenderer>().sprite = defaultSprite;
        ArmRight.SetActive(false);
        ArmLeft.SetActive(false);
    }


   
}
