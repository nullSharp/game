using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 5; i++)
        {
            transform.localScale *= 1.1f;
        }
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
       
        }
    
}
