using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameOverOrNot.HealthDecrease();
        }
        if(other.CompareTag("Pizza"))
        {
            //gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
