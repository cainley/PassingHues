using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed = 0.022f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement for the player
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0);
            Debug.Log("A key was pressed.");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0);
            Debug.Log("D key was pressed.");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0);
            Debug.Log("W key was pressed.");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -speed, 0);
            Debug.Log("S key was pressed.");
        }
    }
}
