using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private BallController ballController;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 dir = ballController.GetDirectionVector();

        rb.AddForce(dir * speed);

        rb.AddForce(Physics.gravity * 5);
    }
}
