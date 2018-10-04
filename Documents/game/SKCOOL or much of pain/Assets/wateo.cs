using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wateo : MonoBehaviour {
    public int from;
    public int number;
    public string find;
    public static bool touched_electric = false;
    public GameObject[] waters;
	// Use this for initialization
	void Start () {
        waters[0] = GameObject.Find(find);
    for(int i = from; i < number;i++)
        {
            waters[i] = GameObject.Find("water 1 (" + i + ")");
        }
	}
public void Check()
    {
        if (touched_electric)
        {
            waters[0].tag = "electricwater";
            for (int i = 0; i < 450; i++)
            {
                waters[i].tag = "electricwater";
            }
        }
    }
	// Update is called once per frame
	void Update () {
        Check();
	}
}
