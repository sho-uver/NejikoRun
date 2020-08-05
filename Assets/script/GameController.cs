using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public NejikoController nejiko;
    public Text scoreText;
    public LifePanel lifePanel;

    // Update is called once per frame
    public void Update () {
        int score = CalcScore ();
        scoreText.text = "Score:" + score + "m";
        lifePanel.UpdateLife (nejiko.Life ());
        if (nejiko.Life () <= 0) {
            enabled = false;
            if (PlayerPrefs.GetInt ("HighScore") < score) {
                PlayerPrefs.SetInt ("HighScore", score);
            }
            Invoke ("ReturnToTitle", 2.0f);
        }
    }
    int CalcScore () {
        return (int) nejiko.transform.position.z;
    }
    void ReturnToTitle () {
        SceneManager.LoadScene ("Title");
    }
}