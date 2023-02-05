using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSequence : MonoBehaviour, Isequence
{
    public GameLoopScript GameLoopScript = GameLoopScript.Instance;
    public List<GameObject> gameObjects;
    public bool HealthObject,textbox;
    public float timeToStart;
    public Vector2 ninMaxEnemies;
    // Start is called before the first frame update
    void Start()
    {
        GameLoopScript = GameObject.Find("MainGameLoop").GetComponent<GameLoopScript>();
    }
    private void OnEnable()
    {
        Invoke("firstLevel", timeToStart);
    }
    // Update is called once per frame
    void Update()
    {
        GameLoopScript = GameObject.Find("MainGameLoop").GetComponent<GameLoopScript>();
    }
    private void firstLevel()
    {
        if (textbox == false)
        {
            float numberOfEnemies = Random.Range(ninMaxEnemies.x, ninMaxEnemies.y);
            int _numberOfEnemies = (int)numberOfEnemies;

            for (var i = 0; i < _numberOfEnemies; i++)
            {
                var x = Random.Range(-3, 3);
                var y = Random.Range(-3, 3);
                var obj = Instantiate(gameObjects[0], new Vector3(x, y, 0), Quaternion.identity);
                obj.SetActive(true);
            }
            // x = Random.Range(-3, 3);
            // y = Random.Range(-3, 3);
            //var obj1 = Instantiate(gameObjects[0], new Vector3(x, y, 0), Quaternion.identity);
            //obj1.SetActive(true);
            // x = Random.Range(-3, 3);
            // y = Random.Range(-3, 3);
            //var obj2 = Instantiate(gameObjects[0], new Vector3(x, y, 0), Quaternion.identity);
            //obj2.SetActive(true);
            if (HealthObject)
            {
                var x = Random.Range(-3, 3);
                var  y = Random.Range(-3, 3);
                var obj3 = Instantiate(gameObjects[1], new Vector3(x, y, 0), Quaternion.identity);
                obj3.SetActive(true);
            }
            GameLoopScript.enemiesAlive += _numberOfEnemies;
        }
        else
        {
            GameLoopScript.sequenceNr = 0;
            var obj = Instantiate(gameObjects[0]);
            GameLoopScript.enemiesAlive += 3;
        }
        //GameLoopScript.enemiesAlive += 3;
        GameLoopScript.isEnemiesLaunched = true;
    }
}
