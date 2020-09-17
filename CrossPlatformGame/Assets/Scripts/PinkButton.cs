using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkButton : MonoBehaviour
{
    public GameObject blueButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //ACTIVATES BLUE BUTTON AND GETS RID OF PINK BUTTON
            blueButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
