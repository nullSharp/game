using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class achkitupastiy : MonoBehaviour {
    public Text text;
    // Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.color = Color.black;
    }

    // Update is called once per frame
    void Update () {
        text.text = "Ачки тупастий:" + person.achki_tupastiy;
      
	}
}
