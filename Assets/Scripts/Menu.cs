using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject SettingsMenu;
    [SerializeField] TMP_Dropdown FpsDropdown;
    [SerializeField] Toggle FullScreenToggle;
    [SerializeField] public static int frame;
    [SerializeField] public static float fpsTimer =3f;
    [SerializeField] public static float pollingTime = 1f;
    [SerializeField] public Text fpsText;
    void Update()
    {
        fpsTimer += Time.deltaTime;
        frame++;
        if (fpsTimer >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frame / fpsTimer);
            fpsText.text = frameRate.ToString() + " FPS";
            fpsTimer -= pollingTime;
            frame = 0;
        }
    }
    void Start()
    {
        QualitySettings.vSyncCount = 0;
    }
    public void OpenSettings()
    {
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
    public void CloseSettings()
    {
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void FpsSetting()
    {
        switch (FpsDropdown.value)
        {
            case 0:
                Application.targetFrameRate = 30;
                break;
            case 1:
                Application.targetFrameRate = 60;
                break;
            case 2:
                Application.targetFrameRate = 90;
                break;
            case 3:
                Application.targetFrameRate = 120;
                break;
            case 4:
                Application.targetFrameRate = 144;
                break;
            case 5:
                Application.targetFrameRate = -1;
                break;
        }
    }
    public void FullScreen()
    {
        FullScreenToggle.isOn = Screen.fullScreen;
    }
}
