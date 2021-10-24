using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    //Audio Related
    [SerializeField] TextMeshProUGUI volText;
    //Main Background Audio, add more AudioSource variables for additional audio
    //ADJUST VolNumText and VolumeSlider for default audio (Default: 80)
    public AudioSource backgroundAudio;


    public void setVolume(float volume)
    {
        volText.text = volume.ToString("");
        //Had to do * 0.01f because volume is currently from 0-100, do same for any additional audio
        backgroundAudio.volume = volume * 0.01f;

    }

    public void setFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
