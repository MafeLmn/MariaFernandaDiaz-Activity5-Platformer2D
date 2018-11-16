using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Volume : MonoBehaviour{

    public AudioMixer masterMixer;

    public void SetSFXLvl (float SFXlevel)

    {
        masterMixer.SetFloat ("SFXVolume", SFXlevel);
    }

public void SetMusiclevel (float musiclevel)
{
    masterMixer.SetFloat("MusicVolume", musiclevel);
}

}

