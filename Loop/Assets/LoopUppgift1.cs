using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LoopUppgift1 : MonoBehaviour {

	// Use this for initialization
	void Start ()
    { 
        // Makes a list
        List<int> list = new List<int>();
        // Adds value to the list
        list.Add(27);
        list.Add(59);
        list.Add(93);
        list.Add(38);
        list.Add(31);
        list.Add(97);
        list.Add(74);
        list.Add(50);
        list.Add(62);
        list.Add(78);
        // A loop that checks the list
        for(int i = 0; i < list.Count; i++)
        {
            // Prints the list
            print(list[i]);
        }            
    }
	
	// Update is called once per frame
	void Update () {
     
	}
}
