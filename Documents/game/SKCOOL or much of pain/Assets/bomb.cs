using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {
    private bool c = true;
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
       if(c)
        {
            StartCoroutine(TI());
        }
        }
    IEnumerator TI()
    {
        c = false;
        yield return new WaitForSeconds(0.3f);    
        transform.localScale *= 1.1f;
        yield return new WaitForSeconds(0.3f);
        transform.localScale *= 1.1f;
        yield return new WaitForSeconds(0.3f);
        transform.localScale *= 1.1f;
        Destroy(gameObject);
    }
}
