using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action_of_move : MonoBehaviour {
    [SerializeField] private GameObject point;
    private GameObject player;
    public static bool touch = false;
    private bool do_action = false;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("troll");
	}
	
	// Update is called once per frame
	void Update () {
		if(touch)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                do_action = !do_action;
            }
            if (do_action)
            {
                player.transform.position = point.transform.position;
            }
            }
	}
    private void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Player")
        {
            touch = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            touch = true;
        }
    }
}
