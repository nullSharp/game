using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XY : MonoBehaviour {
    public static Vector2 LEFT, RIGHT, UP, DOWN, UPRIGHT, UPLEFT, DOWNLEFT, DOWNRIGHT;
    private void Start()
    {
        LEFT = Vector2.left;
        RIGHT = Vector2.right;
        UP = Vector2.up;
        DOWN = Vector2.down;
        UPRIGHT = new Vector2(1, 1);
        UPLEFT = new Vector2(-1, 1);
        DOWNLEFT = new Vector2(-1, -1);
        DOWNRIGHT = new Vector2(1, -1);
    }
}
