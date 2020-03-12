using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSoundEffect : MonoBehaviour
{
    AudioSource[] audioSource;
    AudioSource audioPuckHit;
    AudioSource audioWallHit;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponents<AudioSource>();
        audioPuckHit = audioSource[0];
        audioWallHit = audioSource[1];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Puck")
            audioPuckHit.Play();

        else if (collision.gameObject.tag == "Wall")
            if (collision.relativeVelocity.magnitude > 6)
                audioWallHit.Play();
    }
}
