using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;

	public GameObject TopPanel;
	public GameObject gameOverPanel;
	public GameObject taptext;
	public Text score;
	public Text highScore1;
	public Text highScore2;

	void Awake()
	{
		if (instance == null) 
		{
			instance = this;
		}
	}

	void Start () 
	{
		highScore1.text = "High Score: " + PlayerPrefs.GetInt ("highScore");
	}
	
	public void GameStart()
	{
		taptext.SetActive (false);
		TopPanel.GetComponent<Animator> ().Play ("PanelUp");
	}

	public void GameOver ()
	{
		score.text = PlayerPrefs.GetInt ("score").ToString();
		highScore2.text = PlayerPrefs.GetInt ("highScore").ToString();
		gameOverPanel.SetActive (true);
	}

	public void Reset()
	{
		SceneManager.LoadScene ("Level1");
	}

	void Update () {
		
	}
}
