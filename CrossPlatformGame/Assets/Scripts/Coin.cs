using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float spin = 60f;
    //private float scoreToGive = 100f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        //SPINS OBJECT
        transform.Rotate(Vector3.right, spin * Time.deltaTime);
    }
}
