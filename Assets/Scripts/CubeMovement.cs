using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movementSpeed, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(movementSpeed * 2, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0, 0, -movementSpeed * 2);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        }


    }
}
