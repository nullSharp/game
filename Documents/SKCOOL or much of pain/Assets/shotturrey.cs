using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotturrey : MonoBehaviour {
    public GameObject bullet;
    private bool canShoot = true;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(canShoot)
        {
            StartCoroutine(Shoot());
        }
	}
IEnumerator Shoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(0.4f);
        GameObject go = Instantiate(bullet, this.transform.position, Quaternion.identity);
        go.GetComponent<Rigidbody2D>().AddForce(new Vector2(-90,0), ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.4f);
        canShoot = true;
    }
}
