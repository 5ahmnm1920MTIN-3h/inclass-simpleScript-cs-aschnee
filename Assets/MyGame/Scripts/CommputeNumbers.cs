using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommputeNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    float varA;
    float varB;

    // Start is called before the first frame update
    void Start()
    {
        varA = 5;
        varB = 4;
        AddNumbers(varA, varB);
        AddNumbers(4, 7);
        Debug.Log("in Start: " + AddNumbers(varA, varB));
        Debug.Log("in Start: " + AddNumbers(4, 7));
        Debug.Log(10 - AddNumbers(varA, varB));
        Debug.Log(100 - AddNumbers(4, 7));
        
    }

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in SetResult" + (a + b));
        //result.text = SubstractNumbers(a, b);
        float resultAB = a + b;
        result.text = resultAB.ToString();

    }

    public float AddNumbers(float variableA, float variableB)
    {
        float result = variableA + variableB;
        //Debug.Log("Test sub" + result.ToString());
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
