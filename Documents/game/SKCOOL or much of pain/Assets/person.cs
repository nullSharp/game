using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class person : MonoBehaviour {
    public static bool picked_warp_axe = false;
    public GameObject dragon_ball;
    public GameObject warp_axe;
    public warpaxe_attack warpaxe_;
    public GameObject targ;
    public static int power;
   [SerializeField] private Rigidbody2D rigidbody;
    private bool canJump = true;   
    [SerializeField] private BoxCollider2D bo;
    public static string level;
    private bool run = false;
   [SerializeField]private float energy = 100f;
    public GameObject filter;
    private bool slowly = false;
    public static int direction;
    private bool c = true;
    public GameObject pointOfBullet;
    private float groundRadius = 0.15f;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public int typeofweapon = 1;
    public bool canShoot = true;
    public GameObject bullet;
    public static float mana = 5;
    [SerializeField] private SpriteRenderer sprite;
    public static bool died = false;
   [SerializeField] public static float achki_tupastiy;
    public static float life = 4f;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject diescreen;
    private float speed = 16f;
   [SerializeField] public static bool isGround = true;
   [SerializeField]public static bool canMove = true;
    private bool canTakeDamage = true;
    Rigidbody2D rigidbody2D = new Rigidbody2D();
    float player_energy
    {
        get
        {
            return energy;
        }
        set
        {
            energy = value;
        }
    }

    void AnimationOfDamage()
    {
    if(canTakeDamage)
        {
            StartCoroutine(AnimationOfMinusLife());
           
        }
    }
    void Checks()
    {
      
        if (life == 1 && c) {
        speed = speed / 2; 
            c = false;
            slowly = true;
        }
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
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            typeofweapon = 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            typeofweapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            typeofweapon = 3;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && canMove || Input.GetKey(KeyCode.A) && canMove)
        {
            direction = 1;
            transform.rotation = new Quaternion(0, 180, 0, 0);//(0,0,0) что бы был как изначально, (0,180,0) в противоположную сторону        }
            transform.Translate(1 * speed * Time.fixedDeltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && canMove || Input.GetKey(KeyCode.D) && canMove)
        {
            direction = 2;
            transform.rotation = new Quaternion(0, 0, 0, 0);//(0,0,0) что бы был как изначально, (0,180,0) в противоположную сторону        }
            transform.Translate(1 * speed * Time.fixedDeltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGround && canMove && canJump || Input.GetKeyDown(KeyCode.W) && isGround && canMove && canJump)
        {
            rigidbody2D.AddForce(Vector2.up * 25, ForceMode2D.Impulse);
            StartCoroutine(Jumping());
        }

        if (Input.GetKeyDown(KeyCode.Q)&& mana >= 4 && isGround)
        {
            rigidbody2D.AddForce(Vector2.up * 45, ForceMode2D.Impulse);
            mana -= 4;
        }
     
        if(Input.GetKeyDown(KeyCode.X) && canShoot && typeofweapon == 1)
        {
            if (direction == 1)
            {
                Debug.Log("я радился 1");
                GameObject go = Instantiate(bullet,transform.position, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 250 * Time.deltaTime, ForceMode2D.Impulse);
            }
            if(direction == 2)
            {
                Debug.Log("я радился 2");
                GameObject go = Instantiate(bullet,transform.position, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 250 * Time.deltaTime, ForceMode2D.Impulse);
            }
            StartCoroutine(Timerr());
        }
        if(Input.GetKeyDown(KeyCode.X) && canShoot && typeofweapon == 2 && picked_warp_axe)
        {
            warp_axe.SetActive(true);
            if(direction == 1)
            {
                warpaxe_.LeftAttack();
            }
            if (direction == 2)
            {
                warpaxe_.RightAttack();
            }
           
            StartCoroutine(Timerr());
        }
    }
    // Use this for initialization
    void Start() {
        rigidbody.mass = 2;
        typeofweapon = 2;
        sprite = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        level = "legendofnoops";
    }
    void Die()
    {
        if (slowly)
        {
            filter.SetActive(false);
            speed = speed * 2;
        }
            died = true;
        diescreen.SetActive(true);
        StartCoroutine(Timer());
        slowly = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (canJump)
        {
            isGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        }
            Debug.Log(isGround);
        InputGet();
        Checks();
    }
  IEnumerator Jumping()
    {
        canJump = false;
        yield return new WaitForSeconds(0.05f);
        canJump = true;
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
      
        diescreen.SetActive(false);
        transform.position = spawnPoint.position;
        life = 4;
        canMove = true;
        died = false;
        c = true;
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
        if(collision.gameObject.tag == "electric" && canTakeDamage)
        {
            life--;
            life--;
            AnimationOfDamage();
        }

        if (collision.gameObject.tag == "score")
        {
            achki_tupastiy += 2f + Manager.achkitupastiy_per_second;
        }
        if (collision.gameObject.tag == "Death")
        {
            life = 0;
        }
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       
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