using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class OnOffButtonColorChanger : MonoBehaviour
{
    [SerializeField] private ToggleOnOffButton _button;
    [SerializeField] private Color _activeColor;
    [SerializeField] private Color _inactiveColor;

    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();

        UpdateButtonColor();
    }

    public void UpdateButtonColor()
    {
        Color color = _button.IsOn ? _activeColor : _inactiveColor;

        ChangeButtonColor(color);
    }

    private void ChangeButtonColor(Color color)
    {
        _image.color = color;
    }
}