using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoopScript : MonoBehaviour
{
    public static GameLoopScript Instance = new GameLoopScript();

    public int HP;
    public int XP;
    public int Items;

    public GameObject Hp, Xp, ITems;

    // Start is called before the first frame update
    void Start()
    {
        Initiation();
    }

    private void Awake()
    {
        Initiation();
    }

    // is called for reinitiation of the game 
    void Initiation()
    {
        HP = 100;
        XP = 0;
        Items = 0;
    }
    private void Update()
    {
        ITems.GetComponent<Text>().text = "Items found: " + Items.ToString();
        Hp.GetComponent<Text>().text = "HP: " + HP.ToString();
        Xp.GetComponent<Text>().text = "XP: " + XP.ToString();
    }
}
