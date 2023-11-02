using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab = null;
    [SerializeField] TMP_Text LivesText;

    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        LivesText.text = "Lives: " + lives;
    }

    public void DecreaseLives()
    {
        lives--;
        LivesText.text = "Lives: " + lives;

        if(lives > 0)
        {
            ReSpawnPlayer();
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

    private void ReSpawnPlayer()
    { 
        Vector3 respawnPos = new Vector3(0f, -4f, 0f);
                
        Instantiate(ballPrefab, respawnPos, Quaternion.identity);
        Debug.Log("Respawned");
    }
}
