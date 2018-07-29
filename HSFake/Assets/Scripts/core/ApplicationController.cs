using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void exitGame() {
        Application.Quit();
    }

    public static bool isFirstPlay() {
        if (PlayerPrefs.GetString("FirstPlay") != "fakeStone")
        {
            return true;
        }
        return false;
    }

    public static void setDefaultConfig() {
        PlayerPrefs.SetString("FirstPlay", "fakeStone");
        enebleSoundSFX();
        enebleSoundMusic();
        setVolumeSFX(1);
        setVolumeMusic(1);
    }
    //soud configurations
    //SFX
    public static void enebleSoundSFX() {
        PlayerPrefs.SetInt("SFXsound", 1);
    }
    public static void disabletSoundSFX()
    {
        PlayerPrefs.SetInt("SFXsound", 0);
    }

    public static bool isMuteSoundSFX()
    {
        if (PlayerPrefs.GetInt("SFXsound") == 1 )
        {
            return true;
        }
        return false;
    }

    public static float getVolumeSFX()
    {
        return PlayerPrefs.GetFloat("SFXvolume");
    }

    public static void setVolumeSFX(float volume) {
        PlayerPrefs.SetFloat("SFXvolume", volume);
    }

    //Music
    public static void enebleSoundMusic()
    {
        PlayerPrefs.SetInt("MusicSound", 1);
    }
    public static void disabletSoundMusic()
    {
        PlayerPrefs.SetInt("MusicSound", 0);
    }

    public static bool isMuteSoundMusic()
    {
        if (PlayerPrefs.GetInt("MusicSound") == 1) {
            return true;
        }
        return false;

    }

    public static float getVolumeMusic()
    {
        return PlayerPrefs.GetFloat("MusicVolume");
    }

    public static void setVolumeMusic(float volume)
    {
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

}
