using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

    public AudioSource audio;
    public AudioClip bullet;
    public GameObject score;


    void Start()
    {
        score = GameObject.Find("score");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
    }

    void OnMouseDown ()
    {
        ScoreDisplayer sd = score.GetComponent<ScoreDisplayer>();
        sd.score += 50;
        Destroy(this.gameObject);
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "Bullet(Clone)")
        {
            audio.clip = bullet;
            audio.Play();
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        if (col.gameObject.name == "Player")
        {
            ScoreDisplayer sc = GameObject.Find("score").GetComponent<ScoreDisplayer>();
            sc.health -= 1;
        }
    }
}
