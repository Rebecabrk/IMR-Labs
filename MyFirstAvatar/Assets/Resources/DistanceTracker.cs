using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    public GameObject imageTarget1;
    public GameObject imageTarget2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(imageTarget1.transform.position, imageTarget2.transform.position);
        Debug.Log("Distance: " + distance);
        
        if (distance < 1.0f)
        {
            // Acțiune la apropiere
        }
        else
        {
            // Acțiune la depărtare
        }
    }
}
