using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoopScript : MonoBehaviour
{
    public static GameLoopScript Instance = new GameLoopScript();


    public List<GameObject> monsters;
    public List<GameObject> items = new List<GameObject>();
    public List<GameObject> Bosses = new List<GameObject>();
    public List<GameObject> Sequences = new List<GameObject>();
    public int HP;
    public int XP;
    public int Items;
    public int enemiesAlive;
    public GameObject Hp, Xp, ITems;
    public bool isEnemiesLaunched;
    private int sequenceNr;
    // Start is called before the first frame update
    void Start()
    {

        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        //Initiation();
        sequenceNr = 0;
    }

    private void Awake()
    {
        //Initiation();
    }

    // is called for reinitiation of the game 
   public void Initiation()
    {
        HP = 100;
        XP = 0;
        Items = 0;
        Invoke("gameloop", 5);
        //Invoke("firstLevel", 1);
    }
    private void Update()
    {
        ITems.GetComponent<Text>().text = "Items found: " + Items.ToString();
        Hp.GetComponent<Text>().text = "HP: " + HP.ToString();
        Xp.GetComponent<Text>().text = "XP: " + XP.ToString();


        if(isEnemiesLaunched)
        {
            if(enemiesAlive <= 0)
            {
                //do next sequence
                Sequences[sequenceNr].gameObject.SetActive(false);
                sequenceNr++;
                isEnemiesLaunched = false;
                Invoke("SetSequenceActive", 0);
            }
        }

    }
    private void SetSequenceActive()
    {
        Sequences[sequenceNr].gameObject.SetActive(true);
    }
    private void gameloop()
    {
        ShowTextBox("some text here!");

        //firstLevel();
        SetSequenceActive();

    }
    private void ShowTextBox(string text)
    {

    }

   

}
