using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playinggame : MonoBehaviour
{

    public void playgame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.LoadLevel(1);
        DontDestroyOnLoad(GameObject.Find("Music"));
#endif
    }

}
