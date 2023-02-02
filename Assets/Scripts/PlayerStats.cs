using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health;
    public int XP;

    private void Update()
    {
        GameLoopScript.Instance.HP = health;
        GameLoopScript.Instance.XP = XP;
    }
}
