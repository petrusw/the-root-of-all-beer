using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AddValueToTextScript : MonoBehaviour
{
    public float FloatValue;
    public bool IsValueXP;
    public bool IsInt;
    public int IntValue;
    public Text Text;
    private string baseValue;
    // Start is called before the first frame update
    void Start()
    {
        // Get the base text of the text object
        baseValue = Text.text;

        if (IsValueXP)
        {
            // set the XP floatValue
            FloatValue = GameLoopScript.Instance.XP;
        }
        else
        {
            // Get the HP floatValue
            FloatValue = GameLoopScript.Instance.HP;
        }

        // Get IntValue
        IntValue = GameLoopScript.Instance.Items;

        // add the base text value with the value
        string _addedstring = baseValue + " " + FloatValue.ToString();

        // set the displayed text
        Text.text =_addedstring ;
    }

    private void Update()
    {
        if (IsValueXP)
        {
            float _fValue = GameLoopScript.Instance.XP;
            UpdateValue(_fValue);
        }
        else if(IsInt)
        {
            UpdateValue(GameLoopScript.Instance.Items);
        }
        else
        {
            float _fValue = GameLoopScript.Instance.HP;
            UpdateValue(_fValue);
        }

    }


    public void UpdateValue(float value)
    {
        Text.text = baseValue + " " + FloatValue.ToString();
    }

    public void UpdateValue(int value)
    {
        Text.text = baseValue + " " + FloatValue.ToString();
    }
}
