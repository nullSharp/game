using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {
    [SerializeField] private GameObject loadingOfMastirino;
    private bool f = true;
    public Transform pos;
    GameObject player = GameObject.FindGameObjectWithTag("Player");
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
    
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player" && f){ StartCoroutine(Ti());}
    }
    IEnumerator Ti()
    {
        loadingOfMastirino.SetActive(true);
        person.canMove = false;
        yield return new WaitForSeconds(3);
        loadingOfMastirino.SetActive(false);
        player.transform.position = pos.position;
        person.canMove = true;
    }
}
