using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electromastir : MonoBehaviour {
    private float X, Y;
    private Vector2 xy;
    public GameObject elecball;
    public Transform empty_trigger;
    public LayerMask ground;
    private float groundRadius = 0.2f;
    public GameObject bomb;
    private Vector2 point;
    private bool isGround = false;
    public Rigidbody2D rigidbody;
    private bool f = true;
    public SpriteRenderer sprite;
    public int life = 3;
    private int direction, speed;
    private bool canChange = true;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        transform.localScale = transform.localScale * 1.5f;
        point = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        player = GameObject.FindGameObjectWithTag("Player");
        sprite = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(empty_trigger.position, groundRadius, ground);
    }
    // Update is called once per frame
    void Update()
    {
        if (canChange && !peso.attack)
        {
            direction = Random.Range(1, 3);
            if (direction == 1)
            {
                transform.Translate(2 * Time.fixedDeltaTime, 0, 0);
                StartCoroutine(Timer());
            }
            else
            {
                transform.Translate(2 * Time.fixedDeltaTime, 0, 0);
                StartCoroutine(Timer());
            }
        }
        if (person.life < 1)
        {
            this.transform.position = point;
            peso.attack = false;
            life = 3;
        }
        if (life < 1)
        {
            person.mana += 1f;
            person.achki_tupastiy += 2f + Manager.achkitupastiy_per_second;
            Instantiate(bomb, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (peso.attack)
        {

            transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, 30 * Time.fixedDeltaTime);
            int jump = Random.Range(1, 140);
            if (jump == 16 && isGround)
            {
                rigidbody.AddForce(Vector2.up * 12, ForceMode2D.Impulse);
                isGround = false;
            }
            if(jump >= 20)
            {
                xy = new Vector2(gameObject.transform.position.x + Random.Range(-10, 15f), gameObject.transform.position.y + Random.Range(-10, 6f));
                Instantiate(elecball, xy, Quaternion.identity);
            }
        }
    }
    IEnumerator Timer()
    {
        canChange = false;
        yield return new WaitForSeconds(2);
        canChange = true;
    }
    IEnumerator Timeri()
    {
        f = false;
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.03f);
        sprite.color = Color.white;
        f = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet" && f)
        {
            life--;
            StartCoroutine(Timeri());
        }
        if (collision.gameObject.tag == "minuslife")
        {
            transform.Translate(Random.Range(-4, 4) * Time.fixedDeltaTime, 0, 0);
            if (isGround)
            {
                rigidbody.AddForce(Vector2.up * 12, ForceMode2D.Impulse);
                isGround = false;
            }
        }
        if (collision.gameObject.tag != "bullet" && isGround)
        {
            rigidbody.AddForce(Vector2.up * 12, ForceMode2D.Impulse);
            isGround = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            life = 0;
        }
    }
}
