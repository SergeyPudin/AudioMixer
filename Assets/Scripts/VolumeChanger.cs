using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent (typeof(Slider))]
public class VolumeChanger : MonoBehaviour
{
    [SerializeField] AudioMixerGroup _mixer;

    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();

        ChangeVolume(_slider.value);
    }

    public void ChangeVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(_mixer.name, ConvertToDecibel(volume));       
    }

    private float ConvertToDecibel(float volume)
    {
        float minValue = -80;
        float multiplier = 20;

        if (Mathf.Approximately(volume, 0))
            return minValue; 

        return Mathf.Log10(volume) * multiplier;
    }
}