using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization


	IEnumerator Start ()
	{
		while (true) {
			GetComponent<Monkey> ().Shot (transform, bullet);
			yield return new WaitForSeconds (0.5f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Monkey>().Move (transform.up);
	}
}
