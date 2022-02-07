using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBoundObject : MonoBehaviour
{
    private float lowerBound = -5;
    private float upperBound = 20;
    

    // Update is called once per frame
    void Update()
    {
        DestroyOutOfBoundObjects();
    }

    void DestroyOutOfBoundObjects()
    {
        if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);

            GameOverOrNot.HealthDecrease();
        }

        if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
    }

}
