using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger : MonoBehaviour {
    public GameObject message;
	// Use this for initialization
	void Start () {
        message.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
    if(collision.gameObject.tag == "Player")
        {
            Manager.achkitupastiy_per_second += 1f;
            StartCoroutine(Timer());
            Destroy(gameObject);
        }
    }
    IEnumerator Timer()
    {
        message.SetActive(true);
        yield return new WaitForSeconds(2f);
        message.SetActive(false);
    }
}
