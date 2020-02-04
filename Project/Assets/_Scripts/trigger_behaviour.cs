using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_behaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<bullet_behaviour>())
            Destroy(other.gameObject);
    }
}
