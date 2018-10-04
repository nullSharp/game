using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    public GameObject xspau;
    public GroundObject gr;
    public Transform ground;
    RaycastHit2D rayhit;
    public GameObject fire;
   [SerializeField] public static bool willDestroy = false;
    // Use this for initialization
    void Start()
    {
        rayhit = GetComponent<RaycastHit2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < xspau.transform.position.y)
        {
            willDestroy = true;
        }
        if (gr.isGround && willDestroy)
        {
            Instantiate(fire, transform.position, Quaternion.identity);
        Destroy(gameObject);
        }
    }

}
