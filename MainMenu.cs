using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    GUIStyle guiStyleButton;
    GUIStyle guiStyleBox;
    bool guiStyleSetup = false;
    private float hSliderValue = 0.0f;


    // Use this for initialization
    void Start()
    {
    }

    void OnGUI()
    {
        if (guiStyleSetup == false)
        {
            guiStyleButton = new GUIStyle(GUI.skin.button);
            guiStyleBox = new GUIStyle(GUI.skin.box);
            guiStyleButton.fontSize = 20;
            guiStyleBox.fontSize = 30;
            guiStyleSetup = true;
        }

        GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 200, 400, 400), "Main Menu", guiStyleBox);

        if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 50), "Level 1", guiStyleButton))
        {
            SceneManager.LoadScene("Level 1");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 40, 300, 50), "Level 2", guiStyleButton))
        {
            SceneManager.LoadScene("Level 2");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 50), "Exit", guiStyleButton))
        {
            Application.Quit();
        }

        GUI.Label(new Rect(Screen.width / 2 - 26, Screen.height / 2 + 24, 100, 50), "Difficulty: " + hSliderValue);

        hSliderValue = GUI.HorizontalSlider(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 45, 100, 30), Mathf.Round(hSliderValue), 0.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}