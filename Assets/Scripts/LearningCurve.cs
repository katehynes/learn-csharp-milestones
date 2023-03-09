using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int myInt = 0;
    public float myFloat = 3.0f;
    public string myString = "Hello";
    private bool myBool = true;
    // Start is called before the first frame update
    void Start()
    {
        // single line comment
        int doubled = DoubleInt(myInt);
        /* this is
        a multi line comment*/
        Debug.Log(myInt);
        Debug.LogFormat("This is myInt doubled: {0}", doubled);
        Debug.Log($"{myString} world!");
        string concatString = "Hello" + " world.";
        Debug.Log(concatString);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// Doubles an integer.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int DoubleInt(int x) {
        return 2 * x;
    }
}
