using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        // GameSettings sýnýfýndan tek bir örnek oluþturulur
        GameSettings gameSettings = GameSettings.GetInstance();

        // GameSettings sýnýfýndaki deðiþkenler okunur ve yazdýrýlýr
        Debug.Log("Difficulty: " + gameSettings.GetDifficulty());
        Debug.Log("Sound Enabled: " + gameSettings.IsSoundEnabled());

        // GameSettings sýnýfýndaki deðiþkenler deðiþtirilir
        gameSettings.SetDifficulty(2);
        gameSettings.SetSoundEnabled(false);

        // Deðiþtirilmiþ deðiþkenler tekrar okunur ve yazdýrýlýr
        Debug.Log("Difficulty: " + gameSettings.GetDifficulty());
        Debug.Log("Sound Enabled: " + gameSettings.IsSoundEnabled());
    }
}
