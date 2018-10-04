using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine : MonoBehaviour {
    public LayerMask player;
    public bool player_jump = false;
    private bool calalal = true;
    public Rigidbody2D player_rigidbody;
    private Rigidbody2D mine_rigidbody;
    private bool _canDes = true;
    public bool bomb;
    public GameObject bomb_g;
    [SerializeField] public SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
        mine_rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        player_jump = Physics2D.OverlapCircle(transform.position, 6, player);
    }
    // Update is called once per frame
    void Update () {
        calalal = Physics2D.OverlapCircle(transform.position, 0.6f, 8);
        if (bomb && _canDes)
        {
            StartCoroutine(DestroY());
        }
	}
    IEnumerator DestroY()
    {
        _canDes = false;
        yield return new WaitForSeconds(1);
        sprite.color = Color.red;
        yield return new WaitForSeconds(1);
        sprite.color = Color.white;
        yield return new WaitForSeconds(1);
        sprite.color = Color.red;
        yield return new WaitForSeconds(1);
        if (player_jump)
        {
            player_rigidbody.AddForce(Vector2.up * 70, ForceMode2D.Impulse);
        }
        yield return new WaitForSeconds(0.4f);
        Instantiate(bomb_g, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            if (person.direction == 1)
            {
                mine_rigidbody.AddForce(XY.UPLEFT * 15, ForceMode2D.Impulse);
            }
            if (person.direction == 2)
            {
                mine_rigidbody.AddForce(XY.UPRIGHT * 15, ForceMode2D.Impulse);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            if (person.direction == 1)
            {
                mine_rigidbody.AddForce(XY.UPLEFT * 15, ForceMode2D.Impulse);
            }
            if (person.direction == 2)
            {
                mine_rigidbody.AddForce(XY.UPRIGHT * 15, ForceMode2D.Impulse);
            }
        }
        if (collision == null)
        {
            transform.Rotate(0, 0, 2);
        }
        if(collision.gameObject.tag == "Player")
        {
            bomb = true;
        }
        
    }
}
