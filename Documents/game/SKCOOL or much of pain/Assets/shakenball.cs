using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakenball : MonoBehaviour {
    public GameObject parent;
    [SerializeField] private bool goright;
    public GameObject bul;
    private bool a = true;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(goright)
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-1 * Time.deltaTime, 0, 0);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != null)
        {
            transform.position = parent.transform.position;
        }
    }
}
