using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 500f;
    public float xForce = 350f;
    public float jump = 700f;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
        // rb.AddForce(0, 500, 100);
    }

    // Да, это хреновая идея, но шо поделац
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
            rb.AddForce(-xForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
            rb.AddForce(xForce * Time.deltaTime, 0, 0);

        if (rb.position.y < -1f)
            FindObjectOfType<GameManager>().EndGame();
    }
}
