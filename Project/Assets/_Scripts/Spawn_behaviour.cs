using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_behaviour : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> spawn_list;
    public GameObject enemy;
    public float spawn_time = 2.0f;
    private float initial_time=2.0f;
    private int val;
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if ( Time.timeSinceLevelLoad > spawn_time)
        {
            for (int i = 0; i < spawn_list.Capacity; i++)
            {
                val = Random.Range(0, 2);
                enemy.GetComponent<move>().movespeed = Random.Range(1.0f, 15.0f);
                if(val==1)
                   Instantiate(enemy, spawn_list[i].transform.position, Quaternion.identity);
            }
            spawn_time=Time.timeSinceLevelLoad + initial_time;
        }
                
           
	}
}
