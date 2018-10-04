using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public Transform parent;
    [SerializeField] public  List<GameObject> allItems = new List<GameObject>();
    [SerializeField] public  List<GameObject> items = new List<GameObject>();
    [SerializeField] public  List<bool> items_contains = new List<bool>();
    [SerializeField] public  int items_free = 3;
    [SerializeField] public int i_items = -1;
    // Use this for initialization
  
    void Start () {
        items_free = 3;
        i_items = -1;
        items_contains[0] = true;
        items_contains[1] = true;
        items_contains[2] = true;
       // ItemAdd(allItems[1 + i_items]);
    }
	public void ItemAdd(GameObject item)
    {
    if(i_items < 4 && items_contains[i_items + 1] == true)
        {
            items_free--;
            Debug.Log("lal");
           GameObject itemka = Instantiate(item, items[i_items + 1].transform.position,Quaternion.identity,parent);
            itemka.SetActive(true);
            items_contains[i_items + 1] = false;
            i_items++;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
