using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject bullet;

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
			yield return new WaitForSeconds (0.5f);
		}
	}
}
