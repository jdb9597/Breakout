using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUp : MonoBehaviour {

    public GameObject mm;
    Slider mySlider;
    GameObject Menu;
    public Text diff;
    public int difficulty;
	// Use this for initialization
    void Awake ()
    {
       Menu = Instantiate(mm);
       Menu.transform.position = new Vector3(280, 139, 0);
        mySlider = Menu.GetComponent<Slider>();
        diff = GameObject.Find("DiffiTxt").GetComponent<Text>();
        difficulty = Mathf.RoundToInt(mySlider.value);
        diff.text = "Difficulty:  " + difficulty;
        Debug.Log(diff.text);
    }
	void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update () { 
    }

    public void diffitxt(float mySliderval)
    {
        Text d = GameObject.Find("DiffiTxt").GetComponent<Text>();
        difficulty = Mathf.RoundToInt(mySliderval);
        d.text = "Difficulty:  " + difficulty;
        Debug.Log(d.text);
        Debug.Log(difficulty);
    }
}
