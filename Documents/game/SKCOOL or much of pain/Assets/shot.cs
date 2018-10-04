using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour {
    [SerializeField] private float f;
    [SerializeField] private GameObject bullet;
    private bool canShoot = false;
    [SerializeField] public int direction = 0;
    // Use this for initialization
	void Start () {
        StartCoroutine(Starti());	
	}
	IEnumerator Starti()
    {
        yield return new WaitForSeconds(2);
        canShoot = true;
    }
    
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(person.life < 1)
        {
            StartCoroutine(Starti());
            canShoot = false;
        }
    if(canShoot)
        {
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
      canShoot = false;
      GameObject go = Instantiate(bullet, this.transform.position, Quaternion.identity);
      go.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 20,ForceMode2D.Impulse);
      yield return new WaitForSeconds(1.5f);
      canShoot = true;
    }
}
