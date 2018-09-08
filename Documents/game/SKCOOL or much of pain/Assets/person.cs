using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour {
    public int direction;
    public GameObject pointOfBullet;
    private float groundRadius = 0.15f;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public int typeofweapon = 1;
    public bool canShoot = true;
    public GameObject bullet;
    public static float mana = 50;
    [SerializeField] private SpriteRenderer sprite;
    public static bool died = false;
    public static float achki_tupastiy;
    public static float life = 4999999999999999999999999f;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject diescreen;
    private float speed = 12f;
    public static bool isGround = true;
   [SerializeField]public static bool canMove = true;
    private bool canTakeDamage = true;
    Rigidbody2D rigidbody2D = new Rigidbody2D();
    void AnimationOfDamage()
    {
    if(canTakeDamage)
        {
            StartCoroutine(AnimationOfMinusLife());
        }
    }
    void Checks()
    {
    if(life < 1)
        {
            life = 5;
            mana = 0;
            Die();
        }
        mana += 0.005f;
    }
    void InputGet()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && canMove)
        {
            direction = 1;
            transform.rotation = new Quaternion(0, 180, 0, 0);//(0,0,0) что бы был как изначально, (0,180,0) в противоположную сторону        }
            transform.Translate(1 * speed * Time.fixedDeltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && canMove)
        {
            direction = 2;
            transform.rotation = new Quaternion(0, 0, 0, 0);//(0,0,0) что бы был как изначально, (0,180,0) в противоположную сторону        }
            transform.Translate(1 * speed * Time.fixedDeltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGround && canMove)
        {
            rigidbody2D.AddForce(Vector2.up * 14, ForceMode2D.Impulse);
            isGround = false;
        }
        if(Input.GetKeyDown(KeyCode.Q)&& mana >= 4 && isGround)
        {
            rigidbody2D.AddForce(Vector2.up * 20, ForceMode2D.Impulse);
            mana -= 4;
            isGround = false;
        }
       
        if(Input.GetKeyDown(KeyCode.X) && canShoot)
        {
            if (direction == 1)
            {
                Debug.Log("я радился 1");
                GameObject go = Instantiate(bullet,transform.position, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().AddForce(new Vector2(-20, 0), ForceMode2D.Impulse);
            }
            if(direction == 2)
            {
                Debug.Log("я радился 2");
                GameObject go = Instantiate(bullet,transform.position, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().AddForce(new Vector2(20, 0), ForceMode2D.Impulse);
            }
            StartCoroutine(Timerr());
        }
    }
    // Use this for initialization
    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Die()
    {
            died = true;
        diescreen.SetActive(true);
        canMove = false;
        StartCoroutine(Timer());
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        InputGet();
        Checks();
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        diescreen.SetActive(false);
        transform.position = spawnPoint.position;
        life = 4;
        canMove = true;
        died = false;
    }
    IEnumerator Timerr()
    {
        canShoot = false;
        yield return new WaitForSeconds(0.06f);
        canShoot = true;
    }
    IEnumerator AnimationOfMinusLife()
    {
        canTakeDamage = false;
        
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        sprite.color = Color.white;
        canTakeDamage = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "score")
        {
            achki_tupastiy += 2f + Manager.achkitupastiy_per_second;
        }
        if (collision.gameObject.tag == "Death")
        {
            life = 0;
        }
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "minuslife" && canTakeDamage)
        {
            life--;
            AnimationOfDamage();
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "minuslife" && canTakeDamage)
        {
            life--;
            AnimationOfDamage();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
    }
}