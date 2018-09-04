using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dsakkf : MonoBehaviour {
    private bool _canMove = true;
    public Vector2 _direction;
    public Vector2 _direction_two;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (_canMove)
        {
            StartCoroutine(Timer());
        }
	}
    IEnumerator Timer()
    {
        _canMove = false;
        yield return new WaitForSeconds(2);
        transform.Translate(_direction * Time.fixedDeltaTime);
        transform.Rotate(0, 0, 15);
        yield return new WaitForSeconds(2);
        transform.Translate(_direction_two * Time.fixedDeltaTime);
        transform.Rotate(0, 0, 15);
        _canMove = true;
    }
}
