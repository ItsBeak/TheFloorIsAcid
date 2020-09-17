﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkButton : MonoBehaviour
{
    public GameObject blueButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            blueButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
