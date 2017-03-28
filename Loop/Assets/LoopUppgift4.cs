using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LoopUppgift4 : MonoBehaviour {
    private int a;
    private float b;
    private float c;
    private bool SortList = false;
	// Use this for initialization
	void Start () {
        List<int> list2 = new List<int>();
        List<int> list = new List<int>();
        list.Add(12);
        list.Add(5);
        list.Add(43);
        list.Add(23);
        list.Add(2);
        list.Add(1);

        while (SortList == false)
        {
            for (int i = 0; i < list.Count; i++)
            {
                
                if (list[i] > list[i++])
                {
                    a = list[i];
                    list2.Add(a);
                    print(list2[0]);
                    SortList = true;
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
