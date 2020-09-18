using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxExtension : MonoBehaviour
{
    public float blockExtension;
    public float blockTimer;
    public float timer = 0;
    bool timerReached = false;
    bool isExtended;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timerReached = false;
        if(!timerReached)
        {
            timer += Time.deltaTime;
        }
        if(!timerReached && timer > blockTimer && !isExtended)
        {
            ExtendAfterDelay();
        }
        if(!timerReached && timer > blockTimer && isExtended)
        {
            ResetAfterDelay();
        }
    }

    void ExtendAfterDelay()
    {
        gameObject.transform.localScale += new Vector3(0, blockExtension, 0);
        isExtended = true;
        timerReached = true;
        timer = 0;
    }
    void ResetAfterDelay()
    {
        gameObject.transform.localScale += new Vector3(0, -blockExtension, 0);
        isExtended = false;
        timerReached = true;
        timer = 0;
    }
}
