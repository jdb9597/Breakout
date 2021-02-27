using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Setup : MonoBehaviour {

    public GameObject zombo;
    public GameObject playr;
    public int n;
    GameObject[] zomboCopies = new GameObject[4];
    Transform zombSpawn;
    int difficulty;
    double accumulatedTime = 0.0;
    int r = 0;
	// Use this for initialization
    public void diffi (float mySliderval)
    {
        difficulty = Mathf.RoundToInt(mySliderval);
        if (difficulty == 1)
        {
            n = 10;
        }
        else if (difficulty == 2)
        {
            n = 8;
        }
        else if (difficulty == 3)
        {
            n = 6;
        }
        else if (difficulty == 4)
        {
            n = 5;
        }
        else if (difficulty == 5)
        {
            n = 3;
        }
    }
	void Start () {
        zombSpawn = zombo.transform;
        for (int i = 0; i < 4; i++)
        {
            zomboCopies[i] = Instantiate(zombo);
        }
        foreach (GameObject g in zomboCopies)
        {
            float x = Random.Range(-3.0f, 3.0f);
            float z = Random.Range(-7.0f, 7.0f);
            zombSpawn.position = new Vector3(playr.transform.position.x + x, 3.807f, playr.transform.position.z + z);
            while (Vector3.Distance(zombSpawn.position, GameObject.Find("Player").transform.position) <= 2)
            {
                x = Random.Range(-3.0f, 3.0f);
                z = Random.Range(-7.0f, 7.0f);
                zombSpawn.position = new Vector3(playr.transform.position.x + x, 3.807f, playr.transform.position.z + z);
            }
            g.transform.position = zombSpawn.position;
            Destroy(g, 10);
        }
        r = Random.Range(0, n);
    }
	
	// Update is called once per frame
	void Update () {
        accumulatedTime += Time.deltaTime;
        if (accumulatedTime > r)
        {
            GameObject zo = Instantiate(zombo);
            float x = Random.Range(-3.0f, 3.0f);
            float z = Random.Range(-7.0f, 7.0f);
            zombSpawn.position = new Vector3(playr.transform.position.x + x, 3.807f, playr.transform.position.z + z);
            while (Vector3.Distance(zombSpawn.position, GameObject.Find("Player").transform.position) <= 2)
            {
                x = Random.Range(-3.0f, 3.0f);
                z = Random.Range(-7.0f, 7.0f);
                zombSpawn.position = new Vector3(playr.transform.position.x + x, 3.807f, playr.transform.position.z + z);
            }
            zo.transform.position = zombSpawn.position;
            Destroy(zo, 10);
            accumulatedTime = 0.0;
            r = Random.Range(0, n);
        }
    }
}
