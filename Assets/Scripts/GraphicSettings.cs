using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicSettings : MonoBehaviour
{
    [SerializeField] Dropdown resolutions;
    [SerializeField] Dropdown QualityPreset;
    [SerializeField] Toggle FullscreenMode;
    [SerializeField] Toggle VSyncMode;
    void Start()
    {

    }
    void Awake
    {
        fullscreenToggle.isOn = Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ApplySettings()
    {

        // Save();
    }

    // void Save()
    // {
    //     PlayerPrefs.SetInt("vSync", QualitySettings.vSyncCount);
    //     PlayerPrefs.SetInt("aliasing", aliasing[antiAliasing.value]);
    //     PlayerPrefs.SetInt("texRes", QualitySettings.masterTextureLimit);
    //     PlayerPrefs.SetString("shadowRes", QualitySettings.shadowResolution.ToString());
    //     PlayerPrefs.SetString("shadowQuality", QualitySettings.shadows.ToString());
    //     PlayerPrefs.SetInt("aniso", af[anisotropic.value]);
    //     PlayerPrefs.Save();
    // }

    // void Load()
    // {
    //     QualitySettings.shadows = (ShadowQuality)System.Enum.Parse(typeof(ShadowQuality), PlayerPrefs.GetString("shadowQuality", QualitySettings.shadows.ToString()));
    //     QualitySettings.vSyncCount = PlayerPrefs.GetInt("vSync", QualitySettings.vSyncCount);
    //     vSyncToggle.isOn = (QualitySettings.vSyncCount > 0) ? true : false;
    //     QualitySettings.antiAliasing = PlayerPrefs.GetInt("aliasing", QualitySettings.antiAliasing);
    //     QualitySettings.masterTextureLimit = PlayerPrefs.GetInt("texRes", QualitySettings.masterTextureLimit);
    //     QualitySettings.shadowResolution = (ShadowResolution)System.Enum.Parse(typeof(ShadowResolution), PlayerPrefs.GetString("shadowRes", QualitySettings.shadowResolution.ToString()));
    //     aniso = PlayerPrefs.GetInt("aniso", 16);
    //     AnisoFiltering(aniso);
    //     fullscreenToggle.isOn = Screen.fullScreen;
    // }
}
