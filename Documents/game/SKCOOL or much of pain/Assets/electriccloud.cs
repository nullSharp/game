using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electriccloud : MonoBehaviour {
    public bool attack;
    [SerializeField] private GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(attack)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, 6 * Time.deltaTime);
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }
}
