using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "Score_P1")
            text.text = "Player 1: " + WinTrigger.ScoreP1;
        else if (this.name == "Score_P2")
            text.text = "Player 2: " + WinTrigger.ScoreP2;
    }
}
