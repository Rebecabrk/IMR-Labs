using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    public TextMeshPro target1WinnerText;
    public float max = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float objectY = ball.transform.position.y;
        float distanceToSoil = objectY;

        Debug.Log(distanceToSoil);

        if (distanceToSoil < 0.04){
            ball.transform.position = new Vector3(1.5f, 1.61f, 1.2925f);
        }

            float distanceFromStart = (float)Math.Sqrt(ball.transform.position.x * ball.transform.position.x + ball.transform.position.z * ball.transform.position.z);        if (distanceFromStart > max){
            max = distanceFromStart;
        }

        target1WinnerText.text = max.ToString();
    }
}
