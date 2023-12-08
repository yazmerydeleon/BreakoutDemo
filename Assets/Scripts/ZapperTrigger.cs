using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZapperTrigger : MonoBehaviour
{
    [SerializeField] LivesManager livesManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            livesManager.DecreaseLives();

            livesManager.ReSpawnPlayer();
        }
    }
}
