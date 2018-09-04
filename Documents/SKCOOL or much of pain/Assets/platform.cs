using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {
    private int tick = 0;
    private bool canChange = true;
    private bool canGo = true;
    public int directionToRight, directionToLeft;
    public Transform p1, p2;
    void FixedUpdate()
    {
        if (canGo && tick < 601)
        {
            if (tick >= 600)
            {
                canGo = false;
                tick = 0;
            }
            transform.Translate(4 * Time.fixedDeltaTime, 0, 0);
            tick++;

        }
        if (!canGo && tick < 601)
        {
            if (tick >= 600)
            {
                canGo = true;
                tick = 0;
            }
            transform.Translate(-4 * Time.fixedDeltaTime, 0, 0);
            tick++;

        }
    }
    IEnumerator TImer()
    {
        canChange = false;
        yield return new WaitForSeconds(2);
        canChange = true;
    }
}
