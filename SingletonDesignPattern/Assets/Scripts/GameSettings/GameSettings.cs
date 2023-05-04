using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    // Tek bir örnek oluþturmak için static bir deðiþken kullanýlýr
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
        // Eðer instance henüz oluþturulmamýþsa yeni bir örnek oluþturulur
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
