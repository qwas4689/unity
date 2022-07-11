using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody ri;

    private float jumpPower = 250.0f;
    private float speed = 0.01f;
    private bool IsJumping = false;


    // Start is called before the first frame update
    void Start()
    {
        ri = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(-speed, 0, 0);
        }
        if (transform.position.y > 0.7f)
        {
            IsJumping = true;
        }
        else
        {
            IsJumping = false;
        }
        jump();
        Reset();
    }

    void jump()
    {
        if (!IsJumping)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ri.AddForce(new Vector3(0, jumpPower, 0));
            }
        }
    }

    private void Reset()
    {
        if (transform.position.y < -3.5f)
        {
            transform.position = new Vector3(0, 0.7f, 0);
            ri.velocity = Vector3.zero;
            ri.angularVelocity = Vector3.zero;
        }
    }
}
