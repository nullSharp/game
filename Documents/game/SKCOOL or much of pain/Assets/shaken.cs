using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaken : MonoBehaviour {
    private bool f = true;
    [SerializeField] private GameObject t1, t2, t3, t4,t5,t6;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(f)
        {
            StartCoroutine(Ti());
        }
	}
    IEnumerator Ti()
    {
        f = false;
        t1.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        t1.SetActive(false);
        t2.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        t2.SetActive(false);
        t3.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        t3.SetActive(false);
        t4.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        t4.SetActive(false);
        t5.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        t5.SetActive(false);
        t6.SetActive(true);
        t1.SetActive(false);
        t2.SetActive(false);
        t3.SetActive(false);
        t4.SetActive(false);
        t5.SetActive(false);
        t6.SetActive(false);

        f = true;
    }
}
