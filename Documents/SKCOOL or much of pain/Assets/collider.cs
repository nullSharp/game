using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {
    public Rigidbody2D platform;
    private bool Found;
    private bool f = true;
    private bool canFall = true;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
      if(person.life < 1 || person.died)
        {
            f = true;
            canFall = true;
        }
    }
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.tag=="Player"&& canFall && f)
        {
            canFall = false;
            platform.gravityScale = 2;
            platform.tag = "Death";
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        f = false;
        yield return new WaitForSeconds(0.4f);
        platform.tag = "nothing";
    }
}
