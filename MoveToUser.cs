using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToUser : MonoBehaviour {

    public GameObject ourUser;
    public Animator anim;
    public GameObject score;
    Rigidbody rb;
    ScoreDisplayer sd;

    // Use this for initialization
    void Start () {
        score = GameObject.Find("score");
        sd = score.GetComponent<ScoreDisplayer>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        anim.Play("walk");
    }
	
	// Update is called once per frame
	void Update () {
        
        Vector3 userPos = ourUser.transform.position;
        Vector3 ourPos = this.transform.position;

        Vector3 directionToUser = userPos - ourPos;
        directionToUser.Normalize(); //make length 1

        Quaternion newRotation = Quaternion.LookRotation(directionToUser, Vector3.up);

        transform.rotation = newRotation;
        transform.Translate(Vector3.forward * Time.deltaTime);
        if (Vector3.Distance(transform.position, ourUser.transform.position) <= 2.5)
        {
            this.gameObject.isStatic = true;
            sd.health -= Mathf.RoundToInt(5 * Time.deltaTime);
            anim.SetBool("attack", true);
        }
        //audio.clip = snarl;
        //audio.Play();
    }
}