using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    // Singleton
    public static GameSettings instance;

    public int difficulty;
    public float soundVolume;
    public float musicVolume;
    public string playerName;

    void Awake()
    {
        // Setup singleton
        if (instance != null && instance != gameObject)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }

    public void SaveData(SettingsData data)
    {
        difficulty = data.difficulty;
        soundVolume = data.soundVolume;
        musicVolume = data.musicVolume;
        playerName = data.playerName;
    }
    public SettingsData LoadData()
    {
        SettingsData data;
        data.difficulty = difficulty;
        data.soundVolume = soundVolume;
        data.musicVolume = musicVolume;
        data.playerName = playerName;
        return data;
    }
}

