using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour {
    public Animation a;
    private bool c = true;
	// Use this for initialization
	void Start () {
        a = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if(c)
        {
            StartCoroutine(C());
        }
	}
    IEnumerator C()
    {
        c = false;
        yield return new WaitForSeconds(0.5f);
        a.Play("head_0");
        c = true;
    }
}
