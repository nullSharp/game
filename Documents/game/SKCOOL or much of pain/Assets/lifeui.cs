using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lifeui : MonoBehaviour {
    [SerializeField] private Text text;
	// Use this for initialization
	void Start () {
        text.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Жызни:" + person.life;	
        if(person.life < 1)
        {
            text.color = Color.black;
        }
	}
}
