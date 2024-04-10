using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] AudioMixerGroup _mixer;

    public void ChangeVolume(float volume)
    {
        float maxValue = 0;
        float minValue = -80;

        _mixer.audioMixer.SetFloat(_mixer.name, Mathf.Lerp(minValue, maxValue, volume));
        Debug.Log(_mixer.name);
    }
}