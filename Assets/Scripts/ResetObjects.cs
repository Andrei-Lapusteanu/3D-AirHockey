 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjects : MonoBehaviour
{
    Vector3 initPosition;
    Vector3 initVelocity;
    Quaternion initRotation;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        initPosition = rigidBody.position;
        initRotation = rigidBody.rotation;
        initVelocity = rigidBody.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            transform.position = initPosition;
            transform.rotation = initRotation;
            rigidBody.velocity = initVelocity;
        }
    }
}
