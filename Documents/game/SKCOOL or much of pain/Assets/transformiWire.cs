using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformiWire : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
   [SerializeField] private bool gotodown = true;
    [SerializeField] private Transform up, down;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    if(gotodown)
        {
            transform.position = Vector3.MoveTowards(transform.position, down.position, 2 * Time.fixedDeltaTime);
            if(transform.position == down.position)
            {
                gotodown = false;
            }
        }
    if(!gotodown)
        {
            transform.position = Vector3.MoveTowards(transform.position, up.position, 2 * Time.fixedDeltaTime);
            if (transform.position == up.position)
            {
                gotodown = true;
            }
        }
    }
}
