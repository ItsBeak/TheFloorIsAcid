using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    public bool touchRight;
    public bool touchLeft;

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || touchLeft)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || touchRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    public void DownRight()
    {
        touchRight = true;
    }

    public void UpRight()
    {
        touchRight = false;
    }

    public void DownLeft()
    {
        touchLeft = true;
    }

    public void UpLeft()
    {
        touchLeft = false;
    }
}