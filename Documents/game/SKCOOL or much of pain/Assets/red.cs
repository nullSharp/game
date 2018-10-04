using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour {
    public GameObject pl1, pl2,pl3;
    public Vector2 px, py,pw;
    private bool cand = true;
    // Use this for initialization
    void Start()
    {
        pw = pl3.transform.position;
        px = pl1.transform.position;
        py = pl2.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (person.life < 1)
        {
            pl1.transform.position = px;
            pl2.transform.position = py;
            pl3.transform.position = pw;
            cand = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && cand)
        {
            pl1.SetActive(true);
            pl2.SetActive(true);
            pl3.SetActive(true);
            cand = false;
        }
    }
}
