using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] ScoreManager ScoreManagerReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManagerReference.IncreaseScore();
        Destroy(gameObject);      
    }
}
