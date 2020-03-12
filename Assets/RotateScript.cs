using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(30 * Time.deltaTime, Vector3.up);
    }
}
