using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameStarted = false;

    public bool IsGameStarted => isGameStarted;

    public event System.Action<bool> OnGameStateChanged;

    public void SetGameStarted(bool value)
    {
        isGameStarted = value;
        OnGameStateChanged?.Invoke(value);
    }
}

