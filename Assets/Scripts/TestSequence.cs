using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSequence : MonoBehaviour, Isequence
{
    public GameLoopScript GameLoopScript = GameLoopScript.Instance;
    public List<GameObject> gameObjects;
    public bool HealthObject,textbox;
    // Start is called before the first frame update
    void Start()
    {
        GameLoopScript = GameObject.Find("MainGameLoop").GetComponent<GameLoopScript>();
    }
    private void OnEnable()
    {
        Invoke("firstLevel", 0.1f);
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
            var obj = Instantiate(gameObjects[0], new Vector3(3, 1, 0), Quaternion.identity);
            obj.SetActive(true);
            var obj1 = Instantiate(gameObjects[0], new Vector3(2, 1.5f, 0), Quaternion.identity);
            obj1.SetActive(true);
            var obj2 = Instantiate(gameObjects[0], new Vector3(3.5f, 0.1f, 0), Quaternion.identity);
            obj2.SetActive(true);
            if (HealthObject)
            {
                var obj3 = Instantiate(gameObjects[1], new Vector3(2.5f, 0.1f, 0), Quaternion.identity);
                obj3.SetActive(true);
            }
        }
        else
        {
            var obj = Instantiate(gameObjects[0]);
            obj.SetActive(true);
        }
        GameLoopScript.enemiesAlive += 3;
        GameLoopScript.isEnemiesLaunched = true;
    }
}
