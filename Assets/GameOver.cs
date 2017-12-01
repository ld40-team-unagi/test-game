using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<TextMesh> ().text = "GameOver\nScore:" + ScoreCounter.CurrentScore ().ToString ();

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.GetButtonDown("Action1") || Input.GetButtonDown("Jump")) //マウス左クリック、スペースキー、Aボタン、ジャンプボタンを押した場合
		{
			SceneManager.LoadScene("StartMenu");
		}

	}
}