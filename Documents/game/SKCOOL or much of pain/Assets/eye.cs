using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class eye : MonoBehaviour {
    private bool cs = true;
    public int life = 5;
    public delegate void Ev();
    public event Ev die;
    [SerializeField] private GameObject player;
    public static bool _attack;
    public SpriteRenderer sp;
    private bool ca = true;
    [SerializeField] private GameObject laser;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(_attack)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, 2 * Time.deltaTime);
          
        }
        if (life < 1)
        {
           Destroy(gameObject);
        }
      if(player.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector2(1, 1);
        }
        if (player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector2(-0.99f, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "electric")
        {
            if (ca)
            {
                StartCoroutine(CAK());
            }
        }
    }
    IEnumerator CAK()
    {
        ca = false;
        sp.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        life--;
        sp.color = Color.white;
        ca = true;
    }
}
