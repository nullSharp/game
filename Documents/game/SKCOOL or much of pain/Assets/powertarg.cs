using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powertarg : MonoBehaviour {
    private bool c = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && c)
        {
            StartCoroutine(T());
        }
    }
    IEnumerator T()
    {
        c = false;
        yield return new WaitForSeconds(1);
        transform.localScale /= 2;
        transform.Rotate(0, 0, 1);
        yield return new WaitForSeconds(0.2f);
        transform.localScale /= 2;
        transform.Rotate(0, 0, 1);
        yield return new WaitForSeconds(0.2f);
        transform.localScale /= 2;
        transform.Rotate(0, 0, 1);
        yield return new WaitForSeconds(0.2f);
        person.power = 1;
        Destroy(gameObject);
    }
}
