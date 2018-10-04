using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kristall : MonoBehaviour {
    public static bool getSkill = true;
    public int life = 25;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(life < 1)
        {
            getSkill = false;
            StartCoroutine(TI());
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="bullet")
        {
            life--;
        }
    }
    IEnumerator TI()
    {
        yield return new WaitForSeconds(0.05f);
        transform.localScale /= 1.5f;
        yield return new WaitForSeconds(0.05f);
        transform.localScale /= 1.5f;
        yield return new WaitForSeconds(0.05f);
        transform.localScale /= 1.5f;
        Destroy(gameObject);
    }
}
