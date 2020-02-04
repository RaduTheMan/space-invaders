using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet_behaviour : MonoBehaviour {

    // Use this for initialization
    public GameObject GM;
	void Start ()
    {
        GM = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GM.GetComponent<GameManagerScript>().score += 10;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
