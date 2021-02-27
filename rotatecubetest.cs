using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecubetest : MonoBehaviour {
    public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, speed * Time.deltaTime, 0);
	}

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
