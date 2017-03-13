using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LoopUppgift2 : MonoBehaviour {
    public int valA = 7;    

	// Use this for initialization
	void Start () {
        // Makes a list
        List<int> list = new List<int>();
        // Adds value to the list
        list.Add(38);
        list.Add(70);
        list.Add(91);
        list.Add(68);
        list.Add(71);
        list.Add(97);
        list.Add(74);
        list.Add(20);
        list.Add(62);
        list.Add(10);
        // A loop that checks the list
        
        for (int i = 0; i < list.Count; i++)
        {
            // Checks if i and valA have the same value
            if (i == valA)
            {
                // Prints the list
                print(list[i]);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
