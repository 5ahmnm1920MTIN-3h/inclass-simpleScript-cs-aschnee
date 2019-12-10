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
        //result.text = SubstractNumbers(a, b);
        float resultAB = a - b;
        result.text = resultAB.ToString();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
