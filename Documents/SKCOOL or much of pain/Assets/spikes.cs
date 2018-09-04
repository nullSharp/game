using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour {
    public Vector2 player;
    public GameObject zone;
    public Vector2 posXY;
    [SerializeField] private int f;
    [SerializeField] private Vector2 direction;
    [SerializeField] private bool canChangeDirection = true;
    public List<Vector2> directions = new List<Vector2>();
    // Use this for initialization
	void Start () {
        player = gameObject.transform.position;
        posXY = gameObject.transform.position;
        directions.Add(new Vector2(12,0));
        directions.Add(new Vector2(-12, 0));
        directions.Add(new Vector2(0, 12));
        directions.Add(new Vector2(0, -12));
    
    }

    // Update is called once per frame
    void Update () {
        player = gameObject.transform.position;
	if(canChangeDirection && pes.playerwent)
        {
            direction = directions[Random.Range(1, 5)];
            transform.Translate(direction * Time.fixedDeltaTime);
            StartCoroutine(Timer());
        }
  

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "toleft")
        {
            transform.Translate(-20f, 0, 0);
        }
       if(collision.gameObject.tag == "toright")
        {
            transform.Translate(20f, 0, 0);
        }
        if (collision.gameObject.tag == "toup")
        {
            transform.Translate(0, -20f, 0);
        }
        if (collision.gameObject.tag == "todown")
        {
            transform.Translate(0f, 20f, 0);
        }
    }
    IEnumerator Timer()
    {
        canChangeDirection = false;
        yield return new WaitForSeconds(0.3f);
        canChangeDirection = true;
    }
  
    
}
