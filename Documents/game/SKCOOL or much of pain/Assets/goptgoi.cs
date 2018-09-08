using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goptgoi : MonoBehaviour {
    int shouldShoot;
    private bool cango = true;
    public GameObject bullet;
    private int tick = 0;
    private bool canChange = true;
    private bool canGo = true;
    public int directionToRight,directionToLeft;
    public Transform p1,p2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (canGo && tick < 201)
        {
            if (tick >= 200)
            {
                canGo = false;
                tick = 0;
            }
            shouldShoot = Random.Range(1, 200);
            if(shouldShoot == 24 && cango)
            {
                StartCoroutine(Shoot());
            }
            transform.Translate(15 * Time.fixedDeltaTime, 0, 0);
            tick++;
         
        }
        if(!canGo && tick < 201)
        {
            if (tick >= 200)
            {
                canGo = true;
                tick = 0;
            }
            shouldShoot = Random.Range(1, 200);
            if (shouldShoot == 24 && cango)
            {
                StartCoroutine(Shoot());
            }
            transform.Translate(-15 * Time.fixedDeltaTime, 0, 0);
            tick++;
          
        }
    }
    IEnumerator TImer()
    {
        canChange = false;
        yield return new WaitForSeconds(2);
        canChange = true;
    }
    IEnumerator Shoot()
    {
        cango = false;
        yield return new WaitForSeconds(3f);
        Instantiate(bullet, this.transform.position, Quaternion.identity);
        cango = true;
    }
}
