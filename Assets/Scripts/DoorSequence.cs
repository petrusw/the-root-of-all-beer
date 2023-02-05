using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSequence : MonoBehaviour , Isequence
{
    public GameLoopScript GameLoopScript = GameLoopScript.Instance;
    public List<GameObject> Doors;
    public List<GameObject> Doorplacements;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        GameLoopScript = GameObject.Find("MainGameLoop").GetComponent<GameLoopScript>();
        Player = GameObject.Find("Player");
    }
    private void OnEnable()
    {
        Invoke("firstLevel", 0.0f);
        foreach(var d in Doors)
        {
            if(d.activeSelf)
            d.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        GameLoopScript = GameObject.Find("MainGameLoop").GetComponent<GameLoopScript>();
    }
    private void firstLevel()
    {
       
        GameLoopScript.enemiesAlive += 3;
        GameLoopScript.isEnemiesLaunched = true;
    }
}
