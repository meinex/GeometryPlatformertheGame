using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {
    public Vector2 loc;
    public GameObject platform;
    public float speed = 1.5f;
    private bool MovingRight = true;
    private Vector2 startpos;

    private void Start()
    {
        startpos = platform.transform.position;
    }

    void Update () {
        transform.position = new Vector2(platform.transform.position.x + speed, platform.transform.position.y);
        if (MovingRight == true)
        {
            if (transform.position.x >= loc.x)
            {
                MovingRight = false;
                speed = -speed;
            }
        }
        else
        {
            if (transform.position.x <= startpos.x)
            {
                MovingRight = true;
                speed = -speed;
            }
        }
	}
}
