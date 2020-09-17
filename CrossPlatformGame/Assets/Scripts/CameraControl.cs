using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float m_DampTime = 0.2f;
    
    public Transform m_target;

    private Vector3 m_CameraOffset;

    //FINDS WHERE PLAYER SHOULD SPAWN
    //MAY NEED TO CHANGE FOR SCENE PURPOSES
    private void Awake()
    {
        m_target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_CameraOffset = transform.position - m_target.position;
    }

    private void LateUpdate()
    {
        //FOLLOWS PLAYER
        Vector3 newPos = m_target.position + m_CameraOffset;

        transform.position = Vector2.Lerp(transform.position, newPos, m_DampTime);
    }
}
