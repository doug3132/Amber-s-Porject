using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptionsController : MonoBehaviour {
    public Toggle soundSFX;
    public Toggle SoundMusic;
    public Slider sliderSFX;
    public Slider sliderMusic;

	// Use this for initialization
	void Start () {
        if (ApplicationController.isFirstPlay()) {
            ApplicationController.setDefaultConfig();
        }
        soundSFX.isOn = ApplicationController.isMuteSoundSFX();
        SoundMusic.isOn = ApplicationController.isMuteSoundMusic();
        sliderSFX.value = ApplicationController.getVolumeSFX();
        sliderMusic.value = ApplicationController.getVolumeMusic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setSFXSound()
    {
        if (this.soundSFX.isOn) 
        {
            ApplicationController.enebleSoundSFX();
        }
        else
        {
            ApplicationController.disabletSoundSFX();
        }
    }

    public void setMusicSound()
    {
        if (this.SoundMusic.isOn)
        {
            ApplicationController.enebleSoundMusic();
        }
        else
        {
            ApplicationController.disabletSoundMusic();
        }
    }

    public void setVolumeSFX() {
        ApplicationController.setVolumeSFX(this.sliderSFX.value);
    }

    public void setVolumeMusic() {
        ApplicationController.setVolumeMusic(this.sliderMusic.value);
    }
}
