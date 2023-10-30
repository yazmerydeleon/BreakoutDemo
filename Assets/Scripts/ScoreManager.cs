using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab = null;
    [SerializeField] TMP_Text ScoreText;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    public void IncreaseScore()
    { 
        score += 1;
        ScoreText.text = "Score: " + score;
    }
}
