using UnityEngine;
using UnityEngine.Audio;

public class ToggleOnOffButton : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    
    private bool _isOn = true;  

    public bool IsOn => _isOn;    

    public void ToggleButton()
    {
        _isOn = !_isOn;

        ToggleVolume();       
    }   

    private void ToggleVolume()
    {
        float volume;
        float maxValue = 0;
        float minValue = -80;

        volume = _isOn ? maxValue : minValue;

        _mixer.audioMixer.SetFloat(_mixer.name, volume);        
    }
}