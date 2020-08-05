using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour {
    public Text highScoreText;
    public void Start () {
        highScoreText.text = "High Score:" + PlayerPrefs.GetInt ("HighScore") + "m";
    }
    public void OnStartButtonClicked () {
        SceneManager.LoadScene ("main");
    }
}