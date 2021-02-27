using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreDisplayer : MonoBehaviour
{

    public int score;
    public int health;
    public bool gameDone = false;
    public bool doCountdown = true;
    public int maxTime = 30;

    float timeAccumulated = 0f;
    int timeRemaining;

    GUIStyle guiStyleButton;
    GUIStyle guiStyleBox;
    bool guiStyleSetup = false;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
        health = 100;
    }

    void OnGUI()
    {
        if (guiStyleSetup == false)
        {
            guiStyleButton = new GUIStyle(GUI.skin.button);
            guiStyleButton.fontSize = 30;
            guiStyleSetup = true;
        }

        GUILayout.BeginHorizontal("box");
        GUILayout.Button("Score: " + score, guiStyleButton);
        GUILayout.Space(20);
        GUILayout.Button("Health: " + health, guiStyleButton);
        GUILayout.Space(20);
        //if (doCountdown) GUILayout.Button("Time: " + timeRemaining.ToString(), guiStyleButton);
        GUILayout.EndHorizontal();

        if (gameDone)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 80, 300, 100), "GAME OVER", guiStyleButton);

            if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2 + 50, 400, 75), "Click Here to Restart", guiStyleButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                DontDestroyOnLoad(GameObject.Find("Music"));
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 200, 75), "Main Menu", guiStyleButton))
            {
                SceneManager.LoadScene("Main Menu");
                DontDestroyOnLoad(GameObject.Find("Music"));
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        //timeAccumulated += Time.deltaTime;

        //if (doCountdown)
        //{
            //timeRemaining = (int)(maxTime - timeAccumulated);
            //if (timeRemaining <= 0) //are we out of time?
           // {
           //     timeRemaining = 0; //prevent negative numbers
           //     gameDone = true;
              //  Time.timeScale = 0; //don't allow any more movement
//GameObject.Find("Main Camera").GetComponent<MouseCamera>().enabled = false;
          //      Cursor.visible = true;
          //      Cursor.lockState = CursorLockMode.None;
        //        return;
        //    }
       // }
        if (health <= 0)
        {
             health = 0; //prevent negative numbers
             gameDone = true;
             Time.timeScale = 0; //don't allow any more movement/
             GameObject.Find("Main Camera").GetComponent<MouseCamera>().enabled = false;
             Cursor.visible = true;
             Cursor.lockState = CursorLockMode.None;
        }
    }
}