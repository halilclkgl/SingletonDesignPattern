using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    // Tek bir �rnek olu�turmak i�in static bir de�i�ken kullan�l�r
    private static GameSettings instance = null;

    private int difficulty;
    private bool soundEnabled;

    private GameSettings()
    {
        this.difficulty = 1;
        this.soundEnabled = true;
    }

    public static GameSettings GetInstance()
    {
        // E�er instance hen�z olu�turulmam��sa yeni bir �rnek olu�turulur
        if (instance == null)
        {
            instance = new GameSettings();
        }
        return instance;
    }

    public int GetDifficulty()
    {
        return difficulty;
    }

    public void SetDifficulty(int difficulty)
    {
        this.difficulty = difficulty;
    }

    public bool IsSoundEnabled()
    {
        return soundEnabled;
    }

    public void SetSoundEnabled(bool soundEnabled)
    {
        this.soundEnabled = soundEnabled;
    }
}
