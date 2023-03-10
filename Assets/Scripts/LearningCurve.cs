using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int myInt = 0;
    public float myFloat = 3.0f;
    public string myString = "Hello";
    private bool myBool = true;
    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;
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

        // ch 4
        if(myInt == 2) {
            Debug.Log("Just right!");
        }
        else if(myInt - 1 == 2 || myInt + 1 == 2) {
            Debug.Log("So close!");
        }
        else {
            if(myInt < 2) {
                Debug.Log("Too low!");
            }
            else {
                Debug.Log("Too high!");
            }
        }

        string response = "Yes";
        switch(response) {
            case "Yes":
            Debug.Log("Great, let's take a look!");
            break;
            case "No":
            Debug.Log("Okay, let's move on.");
            break;
        }

        int[] myArr = new int[] {1, 2, 3, 4, 5};
        List<string> stringList = new List<string> {"Kate", "Hynes"};
        Dictionary<string, int> points = new Dictionary<string, int> {{"P1", 4}, {"P2", 5}};
        
        for (int i = 0; i < 2; i++) {
            Debug.LogFormat("index: {0} - {1}", i, stringList[i]);
        }
        foreach(string name in stringList) {
            Debug.LogFormat("name: {0}", name);
        }
        foreach(KeyValuePair<string, int> kvp in points) {
            Debug.LogFormat("points: {0} - {1}", kvp.Key, kvp.Value);
        }

        // ch 5
        Character hero = new Character();
        Character heroine = new Character("Agatha");
        hero.PrintStatsInfo();
        heroine.PrintStatsInfo();
        Weapon huntingBow = new Weapon("Hunting Bow", 100);
        Weapon warBow = new Weapon("War Bow", 60);
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);
        directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    
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
