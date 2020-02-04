using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_behavoiur : MonoBehaviour {

    // Use this for initialization
    private float value;
    public bool isDead = false;
    private bool isShoot;
    public float speed;
    public float bullet_speed;
    public GameObject bullet;
    public GameObject GM1;
    private GameObject spawned_bullet;
    private Rigidbody rb;
    public AudioSource shoot_sound;
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        value = Input.GetAxis("Mouse X");
        isShoot = Input.GetMouseButtonDown(0);
        transform.Translate(value*Time.deltaTime*speed,0,0);
        if (isShoot && !isDead && !GM1.GetComponent<GameManagerScript>().isPause)
          shoot();  
    }  
    

    private void shoot()
     {
        shoot_sound.Play();
        spawned_bullet =Instantiate(bullet, transform.position, Quaternion.identity);
        spawned_bullet.transform.rotation = bullet.transform.rotation;
        rb = spawned_bullet.GetComponent<Rigidbody>();
        rb.AddForce(0,0,bullet_speed, ForceMode.Acceleration);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<move>())
        {
            isDead = true;
        }

    }

}
