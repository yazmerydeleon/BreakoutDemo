using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RareBrick : MonoBehaviour
{
    [SerializeField] ScoreManager ScoreManagerReference;
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip RareAudioClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManagerReference.IncreaseScoreSpecial();
        Destroy(gameObject);

        // Start the particle system
        if (particleSystem != null)
        {
            particleSystem.Play();

        }

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.PlayOneShot(RareAudioClip, 0.5f); // Adjust the volume as needed
        }
    }
    // Coroutine to stop the particle system after a delay
    private IEnumerator StopParticleSystemAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Stop the particle system
        if (particleSystem != null)
        {
            particleSystem.Stop();
        }
    }
}
