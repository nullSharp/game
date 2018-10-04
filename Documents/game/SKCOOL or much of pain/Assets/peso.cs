using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peso : MonoBehaviour {
    public GameObject mastir;
    public static bool attack = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = mastir.transform.position;
        if(mastir == null)
        {
            Destroy(gameObject);
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.tag == "Player")
        {
            attack = true;
        }
    }
}
