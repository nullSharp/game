using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chair : MonoBehaviour {
    public PolygonCollider2D pal;
   [SerializeField] GameObject player;
    private bool touch = false;
    public Rigidbody2D r;
    Vector2 player_;
    Vector2 posix;
    // Use this for initialization
	void Start () {
        player_ = new Vector2(player.transform.localScale.x, 0);
        pal = GetComponent<PolygonCollider2D>();
        r = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (touch)
        {
            transform.position = player.transform.position;
            if (Input.GetKeyDown(KeyCode.Z))
            {
                r.AddForce(player_ * 10, ForceMode2D.Impulse);
            }
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {         
            transform.position = player.transform.position;
            touch = true;
        }
    }
}
