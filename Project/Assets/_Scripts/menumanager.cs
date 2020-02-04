using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour {

    // Use this for initialization
    public void play()
    {
        SceneManager.LoadScene(1);

    }
    public void exit()
    {
        Application.Quit();
    }
    
}
