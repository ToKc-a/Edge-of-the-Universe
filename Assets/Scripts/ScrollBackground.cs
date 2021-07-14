using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{

    public float speed = -5f;
    public float lowerYValue = -76f;
    public float upperYValue = 152;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        if (transform.position.y <=lowerYValue)
        {
            transform.Translate(0f, upperYValue, 0f);
        }
    }
}
