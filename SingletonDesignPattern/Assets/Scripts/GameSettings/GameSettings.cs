using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    private static GameSettings instance = null;

    private int difficulty;
    private bool soundEnabled;

    private GameSettings()
    {
        this.difficulty = 1;
        this.soundEnabled = true;
    }

    public static GameSettings Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameSettings();
            }
            return instance;
        }
    }

    public int Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
    }

    public bool SoundEnabled
    {
        get { return soundEnabled; }
        set { soundEnabled = value; }
    }
}
