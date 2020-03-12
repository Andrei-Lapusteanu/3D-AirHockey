using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckSoundEffect : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
            if (collision.relativeVelocity.magnitude > 0)
                audioSource.Play();
    }
}
