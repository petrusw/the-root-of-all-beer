using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> GameObjects;
    public List<GameObject> MenuObjects;
    public Levelgenerator Generator;
    

    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    public void Restart()
    {
        
        foreach (var obj in GameObjects)
        {
            obj.SetActive(false);
        }

        foreach (var obj in MenuObjects)
        {
            obj.SetActive(true);
        }
    }

    public void StartGame()
    {
        foreach (var obj in GameObjects)
        {
            obj.SetActive(true);
        }

        foreach (var obj in MenuObjects)
        {
            obj.SetActive(false);
        }
    }
}
