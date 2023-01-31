using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoopScript : MonoBehaviour
{
    public static GameLoopScript Instance = new GameLoopScript();

    public float HP;
    public float XP;
    public int Items;



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
        HP = 0.0f;
        XP = 0.0f;
        Items = 0;
    }

}
