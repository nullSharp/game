using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {
    private bool go = true;
    public GameObject[] lasers = new GameObject[4];

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(go)
        {
            StartCoroutine(Timer());    
        }
	}
    IEnumerator Timer()
    {
        go = false;
        yield return new WaitForSeconds(0.8f);
        for(int i = 0; i < 5;i++)
        {
            lasers[i].SetActive(true);
        }
        yield return new WaitForSeconds(0.8f);
          for (int i = 0; i < 5; i++)
        {
            lasers[i].SetActive(false);
        }
        go = true;
    }
}
