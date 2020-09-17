using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidPool : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //KILL PLAYER
            Rigidbody playerRigidBody = other.gameObject.GetComponent<Rigidbody>();
            other.gameObject.SetActive(false);
        }
    }
}
