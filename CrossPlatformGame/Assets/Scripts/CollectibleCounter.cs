using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectibleCounter : MonoBehaviour
{

    public Text text;
    public int collectibles;

    void Update()
    {

        text.text = "You have found " + collectibles + " collectibles!";

    }
}
