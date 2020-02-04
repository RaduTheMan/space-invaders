using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour {

    // Use this for initialization
    public Text scoretext;
    public int score=0;
    public bool isPause = false;
    public GameObject pause;
    public GameObject pause_text;
    public GameObject ship_state;
    public GameObject gameover;
    private GameObject obj;
	void Start ()
    {
        PlayerPrefs.GetInt("highscore", 0);
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoretext.text = "Score:" + score.ToString();
        if(Input.GetKeyDown("p"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0; isPause = true;
                pause.SetActive(true);
                pause_text.SetActive(true);
            }
            else
            {
                Time.timeScale = 1; isPause = false;
                pause.SetActive(false);
                pause_text.SetActive(false);
            }
        }
        if( ship_state.GetComponent<ship_behavoiur>().isDead)
        {
            Time.timeScale = 0;
            pause.SetActive(true);
            gameover.SetActive(true);
            gameover.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Score:" + score.ToString();
            if (PlayerPrefs.GetInt("highscore") < score)
                PlayerPrefs.SetInt("highscore", score);
            gameover.transform.GetChild(1).gameObject.GetComponent<Text>().text = "HighScore:" + PlayerPrefs.GetInt("highscore").ToString();
            scoretext.text = null;
        }

	}
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
