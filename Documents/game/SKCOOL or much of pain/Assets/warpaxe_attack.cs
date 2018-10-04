using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpaxe_attack : MonoBehaviour {
    public bool attack = true;
    // Use this for initialization
    void Start () {
		
	}
	public void LeftAttack()
    {
     if(attack)
        {
            StartCoroutine(ATTACK(2));
        }
    }
    public void RightAttack()
    {
        if (attack)
        {
            StartCoroutine(ATTACK(1));
        }
    }
    IEnumerator ATTACK(int dir)
    {
        attack = false;
        if (dir == 1)
        {
          
                transform.Rotate(0, 0, -23,Space.Self);
                yield return new WaitForSeconds(0.000000003f);
                transform.Rotate(0, 0, 23,Space.Self);
                yield return new WaitForSeconds(0.000000003f);
            gameObject.SetActive(false);

        }

        if (dir == 2)
        {
            
                transform.Rotate(0, 0, 23);
                yield return new WaitForSeconds(0.000000003f);
            
            
                transform.Rotate(0, 0, -23);
                yield return new WaitForSeconds(0.000000003f);
           
            gameObject.SetActive(false);
        }
        attack = true;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
