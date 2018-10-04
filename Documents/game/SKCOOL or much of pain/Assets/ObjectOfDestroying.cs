using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOfDestroying : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
void OnTriggerEnter2D(Collider2D col)
    {
    if(col.gameObject.tag=="Bomb")
        {
            StartCoroutine(Die());
        }
    }
    IEnumerator Die()
    {
        yield return new WaitForSeconds(0.2f);
        transform.localScale /= 2;
        yield return new WaitForSeconds(0.2f);
        transform.localScale /= 2;
        yield return new WaitForSeconds(0.2f);
        transform.localScale /= 2;
        Destroy(gameObject);
    }
}
