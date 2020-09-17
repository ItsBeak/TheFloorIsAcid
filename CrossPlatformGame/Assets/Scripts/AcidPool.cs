using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidPool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //KILL
            //other.GetComponent<GameManager>().Update(m_GameState = GameState.GameOver);
            Rigidbody playerRigidBody = other.gameObject.GetComponent<Rigidbody>();
            other.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
