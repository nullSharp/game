using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpaxe : MonoBehaviour {
    public Inventory inventory = new Inventory();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        while(transform.position != collision.transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, collision.transform.position, 2 * Time.fixedDeltaTime);
                transform.Rotate(0, 0, 1,Space.Self);
            }
       if(collision.transform.position == transform.position)
            {
                person.picked_warp_axe = true;
                inventory.ItemAdd(inventory.allItems[1 + inventory.i_items]);
                Destroy(gameObject);
            }
        }
    }
}
