using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStrike : MonoBehaviour
{
    public GameObject PlayerSprite;
    public Sprite NoArmSprite,defaultSprite;
    public GameObject ArmLeft,ArmRight;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1"))
        {
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
        else
        {
            onanimationEnd();
           //if (ArmLeft.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("idle"))
           // {
           //     onanimationEnd();
           // }

           //if(ArmRight.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("idle"))
           // {
           //     onanimationEnd();
           // }
        }

        
    }
    private void onanimationEnd()
    {
        PlayerSprite.GetComponent<SpriteRenderer>().sprite = defaultSprite;
        ArmRight.SetActive(false);
        ArmLeft.SetActive(false);
    }
}
