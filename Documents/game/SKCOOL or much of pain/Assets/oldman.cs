using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldman : MonoBehaviour {
    public GameObject text;
    private bool canShowText = true;
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
            if (canShowText) { StartCoroutine(TI()); }
            if(Input.GetKeyDown(KeyCode.E) && person.achki_tupastiy >= 5)
            {
                person.achki_tupastiy -= 5;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text.SetActive(false);
        }
    }
    IEnumerator TI()
    {
        canShowText = false;
        text.SetActive(true);
        yield return new WaitForSeconds(2);
        text.SetActive(false);
        yield return new WaitForSeconds(1);
        canShowText = true;
    }
}
