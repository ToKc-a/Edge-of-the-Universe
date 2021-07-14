using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroyer : MonoBehaviour
{
    public float timeToDestroy;

    void Start()
    {
        Destroy(gameObject, timeToDestroy);   
    }
}
