using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Image backgroundImage;
    [SerializeField] private Button playButton;
    [SerializeField] private Button playButton1;
    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_Text text2;

    [SerializeField] private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // Ensure the background image is initially visible
        if (backgroundImage != null)
        {
            backgroundImage.enabled = true;
        }
    }

    void PlayButtonClicked()
    {
        // Hide the background image and play button when the play button is clicked
        if (backgroundImage != null)
        {
            backgroundImage.enabled = false;
        }

        if (playButton != null)
        {
            playButton.gameObject.SetActive(false);
        }

        if (playButton1 != null)
        {
            playButton1.gameObject.SetActive(false);
        }

        if (text != null)
        {
            text.gameObject.SetActive(false);
        }
        if (text2 != null)
        {
            text2.gameObject.SetActive(false);
        }

        // Set the game state through GameManager
        if (gameManager != null)
        {
            gameManager.SetGameStarted(true);
        }
    }
}
