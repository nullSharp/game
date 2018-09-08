using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour {
    public Transform player;
    private Vector3 playerpos;
	// Use this for initialization
	void Start () {
        playerpos = new Vector3(player.position.x, player.position.y, -10);
	}
	
	// Update is called once per frame
	void Update () {
        playerpos = new Vector3(player.position.x, player.position.y, -10);
        transform.position = playerpos;
    }
}
