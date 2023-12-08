using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] TMP_Text livesText;
    [SerializeField] TMP_Text gameOverText;

    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.enabled = false;
        livesText.text = "Lives: " + lives;
    }

    public void DecreaseLives()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        Debug.Log("Lives: " + lives);

    }

    public void ReSpawnPlayer()
    {
        Vector3 respawnPos = new Vector3(0f, -2f, 0f);
        if (lives > 0)
        {     
            Instantiate(ballPrefab, respawnPos, Quaternion.identity);
            Debug.Log("Respawned");            
        }
        else
        {
            gameOverText.enabled = true;
        }     
        
       
    }
}
