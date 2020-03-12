using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceRotateScript : MonoBehaviour
{
    public float RotateSpeed = 200f;
    public float LightIntensity = 2f;

    // Start is called before the first frame update
    void Start()
    {
        var policeLight = GetComponent<Light>();
        policeLight.intensity = LightIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        var angle = RotateSpeed * Time.deltaTime;
        transform.localRotation *= Quaternion.AngleAxis(angle, Vector3.up);
    }
}
