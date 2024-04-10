using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class OnOffButton : MonoBehaviour
{
    private const string Master = "Master";

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private Color _activeColor;
    [SerializeField] private Color _inactiveColor;

    private bool _isOn = true;  
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();

        UpdateButtonColor();
    }

    public void SwitchButton()
    {
        _isOn = !_isOn;

        SwichMusic();
        UpdateButtonColor();
    }

    private void UpdateButtonColor()
    {
        Color color = _isOn ? _activeColor : _inactiveColor;

        ChangeButtonColor(color);
    }

    private void ChangeButtonColor(Color color)
    {
        _image.color = color;
    }

    private void SwichMusic()
    {
        float volume;
        float maxValue = 0;
        float minValue = -80;

        volume = _isOn ? maxValue : minValue;

        _mixer.audioMixer.SetFloat(Master, volume);
    }
}