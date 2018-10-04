using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterco : MonoBehaviour {
    private bool can = true;
    [SerializeField] private SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.tag == "electricwater")
        {
            sprite.color = Color.gray;
            if(can)
            {
                StartCoroutine(T());
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.tag == "electric")
        {
            gameObject.tag = "electricwater";
           sprite.color = Color.gray;
           wateo.touched_electric = true;
        }
    }
    IEnumerator T()
    {
        can = false;
        yield return new WaitForSeconds(2);
        gameObject.tag = "water";
        sprite.color = Color.white;
        can = true;
    }
}
