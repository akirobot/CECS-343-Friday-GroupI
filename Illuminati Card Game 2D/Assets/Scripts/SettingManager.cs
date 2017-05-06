using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour {
    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Dropdown textureQualityDropdown;
    public Dropdown antialiasingDropdown;
    public Dropdown vSyncDropdown;
    public Slider volumeSLider;

    public Resolution[] resolution;
    public GameSettings gameSettings;
    void OnEnable()
    {
        gameSettings = new GameSettings();

        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullscreenToggle(); });
        resolution = Screen.resolutions;
    }

    public void OnFullscreenToggle()
    {

    }

    public void OnResolutionChange()
    {

    }

    public void OnTextureQualityChange()
    {

    }

    public void OnAntialiasingChange()
    {

    }

    public void OnVSyncChange()
    {

    }

    public void ApplySetting()
    {

    }

    public void LoadSetting()
    {

    }

	
}
