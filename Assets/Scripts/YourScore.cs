using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class YourScore : MonoBehaviour
{
    TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Your score: " + Score.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
