using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullethell : MonoBehaviour {
    private bool cl = true;
    private bool cb = false;
    private Vector2 plus;
    private bool ca = true;
    public GameObject player;
	// Use this for initialization
	void Start () {
        StartCoroutine(TI());
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		if(ca)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.1f);
        }      
    }
    IEnumerator TI()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
