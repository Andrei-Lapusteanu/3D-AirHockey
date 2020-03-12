using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    Rigidbody rb;
    public static int ScoreP1 = 0;
    public static int ScoreP2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Puck")
        {
            if (this.name == "P1_WinWall")
                ScoreP1++;

            else if (this.name == "P2_WinWall")
                ScoreP2++;
        }
    }
}
