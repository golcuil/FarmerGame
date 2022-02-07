using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 20f;
    private float xRange = 15;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        Boundries();

        InstantiatePrefab(projectilePrefab);

    }



    public void Boundries()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        if(transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        if(transform.position.z > 15)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 15);
        }
    }

    void InstantiatePrefab(GameObject gameObject)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gameObject, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
