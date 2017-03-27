using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LoopUppgift3 : MonoBehaviour {
    private float a = 1;
    private float b = 2;
    private float c = 3;
	// Use this for initialization
	void Start () {
        // Makes a list
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        // Adds value to the list
        list.Add(1);
        list.Add(2);
        list.Add(3);

        // A loop that checks the list
        for (int i = 0; i < list.Count; i++)
        {
            if (list[0] == a && list[1] == b && list[2] == c)
           {
                //list2[0] = list[2];
                //list2[1] = list[1];
                //list2[2] = list[0];
                list2.Add(list[2]);
                list2.Add(list[1]);
                list2.Add(list[0]);
                // Prints the list
                print(list2[0]);
                print(list2[1]);
                print(list2[2]);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
