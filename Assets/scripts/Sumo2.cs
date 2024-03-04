using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumo2 : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public float pushTimer = 2f;

    public CapsuleCollider arm1;
    public CapsuleCollider arm2;

    // Update is called once per frame
    void Update()
    {
        pushTimer += 1 * Time.deltaTime;
        if (pushTimer > 2)
        {
            arm1.enabled = false;
            arm2.enabled = false;

            if (Input.GetKeyDown(KeyCode.RightAlt))
            {
                Push();
                pushTimer = 0f;
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0, 0, -speed);
        }
    }

    void Push()
    {
        rb.AddForce(-speed * 1000, 0, 0);
        arm1.enabled = true;
        arm2.enabled = true;
    }
}
