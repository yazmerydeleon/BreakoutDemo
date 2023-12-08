using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
   private GameManager gameManager;

   void Start()
   {
       gameManager = FindObjectOfType<GameManager>();
   }
    void Update()
    {
        Debug.Log("gameManager.IsGameStarted" + gameManager.IsGameStarted);
        if (gameManager != null && gameManager.IsGameStarted)
        {
            ApplyForceWithDelay(1f);
        }        
    }

    void ApplyForceWithDelay(float delay)
    {
        Invoke("ApplyForce", delay);
    }

    void ApplyForce()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(5f, 100f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zapper"))
        {
            // Destroy the existing ball if it exists
            GameObject existingBall = GameObject.FindGameObjectWithTag("Player");
            if (existingBall != null)
            {
                Destroy(existingBall);
            }
        }
    }
}
