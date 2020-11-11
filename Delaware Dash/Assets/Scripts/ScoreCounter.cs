using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public float score = 0;
    public Text text;




    void Start()
    {
        
    }

    void IncreaseScore()
    {
        score += 1 * Time.deltaTime;

    }



    void Update()
    {
        
        text.text = "Your Score: " + score;
    }
}
