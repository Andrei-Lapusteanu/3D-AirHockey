using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_P2 : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float HandleSpeed = 14f;
    private Vector3 maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        maxSpeed = new Vector3(HandleSpeed, 0, HandleSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            if (Mathf.Abs(rigidBody.velocity.x) < maxSpeed.x)
                rigidBody.AddForce(-60, 0, 0, ForceMode.Acceleration);

        if (Input.GetKey(KeyCode.DownArrow))
            if (rigidBody.velocity.x < maxSpeed.x)
                rigidBody.AddForce(60, 0, 0, ForceMode.Acceleration);

        if (Input.GetKey(KeyCode.LeftArrow))
            if (Mathf.Abs(rigidBody.velocity.z) < maxSpeed.z)
                rigidBody.AddForce(0, 0, -60, ForceMode.Acceleration);

        if (Input.GetKey(KeyCode.RightArrow))
            if (rigidBody.velocity.z < maxSpeed.z)
                rigidBody.AddForce(0, 0, 60, ForceMode.Acceleration);
    }
}
