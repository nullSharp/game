using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mastirninjaboss : MonoBehaviour {
    public GameObject fal;
    private Vector2 v;
    private int life = 50;
   public static bool b_attackboss = false;
   public GameObject player;
    public GameObject bullet;
    public Ping ping;
   private bool b_canChange = true;
    private int i_attack;
    // Use this for initialization
	void Start () {
        v = transform.position;
	}
	void Attack()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 3f * Time.fixedDeltaTime);
        if (b_canChange)
        {
            StartCoroutine(TI());
            if(i_attack == 1)
            {
                Instantiate(bullet, this.transform.position, Quaternion.identity);
            }
            if(i_attack == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 5);
            }
        }
    }
	// Update is called once per frame
	void FixedUpdate () {
        Debug.Log(life);
        if(person.life < 1)
        {
            transform.position = v;
            b_attackboss = false;
            life = 50;
        }
        if (life<1) { Destroy(fal);Destroy(gameObject); }
    if(b_attackboss){ Attack(); }
	}
  IEnumerator TI()
    {
        b_canChange = false;
        yield return new WaitForSeconds(0.5f);
        i_attack = Random.Range(1, 3);
        yield return new WaitForSeconds(0.3f);
        b_canChange = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="bullet")
        {
            life--;
        }
    }
}
