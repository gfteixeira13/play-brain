using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audiomixer;
    
    public void setVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }
}
