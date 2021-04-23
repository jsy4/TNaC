using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public AudioMixer mixer;
    public void setVolume(float sliderValue) 
    {
        mixer.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
    } // youtube.com/watch?v=xNHSGMKtlv4
}
