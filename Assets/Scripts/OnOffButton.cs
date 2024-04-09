using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class OnOffButton : MonoBehaviour
{
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
        UpdateButtonColor();
    }

    private void UpdateButtonColor()
    {
        Color color = _isOn ? Color.white : Color.red;
        ChangeButtonColor(color);
    }

    private void ChangeButtonColor(Color color)
    {
        _image.color = color;
    }
}