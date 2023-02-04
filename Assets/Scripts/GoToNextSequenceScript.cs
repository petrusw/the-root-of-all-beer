using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToNextSequenceScript : MonoBehaviour
{
   public void startNextSequenceFromButton()
    {
        GameLoopScript _gmscript = GameObject.Find("MainGameLoop").GetComponent<GameLoopScript>();

        if(_gmscript != null)
        {
            _gmscript.enemiesAlive = 0;
            _gmscript.isEnemiesLaunched = true;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }

    public void Destroy()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }

    public void StartNewGame()
    {
        var obj = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        foreach(var i in obj.GameObjects)
        {
            i.SetActive(false);
        }
        foreach(var j in obj.MenuObjects)
        {
            j.SetActive(true);
        }
    }
}
