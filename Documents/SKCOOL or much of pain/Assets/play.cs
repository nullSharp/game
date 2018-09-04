using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour {
    [SerializeField] Rigidbody2D rigidbody2D;
    private bool f = true;
   [SerializeField]private Transform XY;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (person.life < 1 || person.died)
        {
                rigidbody2D.gravityScale = 0;
                transform.position = XY.position;
                f = true;
        }
       
		if(rigidbody2D.gravityScale == 2 && f && person.life > 0)
        {
            StartCoroutine(Timer());
        }
	}
    IEnumerator Timer()
    {
        f = false;
        yield return new WaitForSeconds(0.8f);
        gameObject.tag = "nothing";
    }
    
}
