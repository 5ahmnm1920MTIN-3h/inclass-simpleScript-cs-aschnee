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
        SubNumbers(varA, varB);
        SubNumbers(4, 7);
        InitVariables();
    }
    public void InitVariables()
    {
        varA = 0;
        varB = 0;
    }
    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in SetResult" + (a - b));
        //result.text = SubstractNumbers(a, b);
        float resultAB = a - b;
        result.text = resultAB.ToString();

    }

    public float SubNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        //Debug.Log("Test sub" + result.ToString());
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
