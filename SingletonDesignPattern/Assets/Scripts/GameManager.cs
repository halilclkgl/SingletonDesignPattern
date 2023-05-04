using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        // GameSettings s�n�f�ndan tek bir �rnek olu�turulur
        GameSettings gameSettings = GameSettings.GetInstance();

        // GameSettings s�n�f�ndaki de�i�kenler okunur ve yazd�r�l�r
        Debug.Log("Difficulty: " + gameSettings.GetDifficulty());
        Debug.Log("Sound Enabled: " + gameSettings.IsSoundEnabled());

        // GameSettings s�n�f�ndaki de�i�kenler de�i�tirilir
        gameSettings.SetDifficulty(2);
        gameSettings.SetSoundEnabled(false);

        // De�i�tirilmi� de�i�kenler tekrar okunur ve yazd�r�l�r
        Debug.Log("Difficulty: " + gameSettings.GetDifficulty());
        Debug.Log("Sound Enabled: " + gameSettings.IsSoundEnabled());
    }
}
