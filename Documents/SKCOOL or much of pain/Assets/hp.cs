using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour {
    private bool can = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
         if(can)
            {
                StartCoroutine(Imer());
            }
        }
    }
    IEnumerator Imer()
    {
        can = false;
        transform.localScale *= 1.5f;
        person.life++;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
