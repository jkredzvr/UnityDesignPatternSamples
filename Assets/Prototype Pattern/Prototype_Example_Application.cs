using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype_Example_Application : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ColorManager colormanager = new ColorManager();

        // Initialize with standard colors
        colormanager["red"] = new Color(255, 0, 0);
        colormanager["green"] = new Color(0, 255, 0);
        colormanager["blue"] = new Color(0, 0, 255);

        // User adds personalized colors
        colormanager["angry"] = new Color(255, 54, 0);
        colormanager["peace"] = new Color(128, 211, 128);
        colormanager["flame"] = new Color(211, 34, 20);

        // User clones selected colors
        Color color1 = colormanager["red"].Clone() as Color;
        Color color2 = colormanager["peace"].Clone() as Color;
        Color color3 = colormanager["flame"].Clone() as Color;

        Debug.Log(color1.GetRGBVal());
        Debug.Log(color2.GetRGBVal());
        Debug.Log(color3.GetRGBVal());

    }

    // Update is called once per frame
    void Update () {


		
	}

    public Color GenericCloner(object thing)
    {
        Color a = (Color) thing;
        Color newClone = a.Clone() as Color;
        return newClone;
    }
}
