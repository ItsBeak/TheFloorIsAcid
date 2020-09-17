using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float jumpHeight = 100.0f;
    public float NumberJumps = 0f;
    public float MaxJumps = 2.0f;
    public bool isGrounded;
    private Rigidbody rb = null;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    isGrounded = true;
    //}

    // Update is called once per frame
    void Update()
    {
        if (NumberJumps > MaxJumps - 1)
        {
            isGrounded = false;
        }
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                //rb.AddForce(Vector3.up * jumpHeight * Time.deltaTime, ForceMode.Impulse);
                rb.AddForce(Vector3.up * jumpHeight);
                NumberJumps += 1;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        NumberJumps = 0;
    }
    private void OnCollisionExit(Collision collision)
    {

    }
