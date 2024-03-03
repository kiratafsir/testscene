using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public Rigidbody rb;
    public int force = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * force);
        }
    }
}
