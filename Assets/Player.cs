using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	public GameObject bullet;
	public uint score = 0;

	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");

		float y = Input.GetAxisRaw ("Vertical");

		Vector3 direction = new Vector3 (x, y, 0).normalized;

		GetComponent<Monkey>().Move (direction);
	}
		
	IEnumerator Start ()
	{
		while (true) {
			GetComponent<Monkey> ().Shot (transform, bullet);
			yield return new WaitForSeconds (1.5f);
		}
	}

	void OnTriggerEnter (Collider c)
	{

		if (c.tag == "EnemyBullet") {
			Destroy (c.gameObject);
			Destroy (gameObject);
			SceneManager.LoadScene ("GameOver");
		}
	}
}
