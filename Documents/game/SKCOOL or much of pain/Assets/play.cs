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
            transform.position = XY.position;
            rigidbody2D.gravityScale = 0;
        }
       
	}
  
    
}
