using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float angle = 0;
    // Update is called once per frame
    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(50 * Time.deltaTime, Vector3.up);
    }
}
