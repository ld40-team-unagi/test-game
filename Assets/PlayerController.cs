using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 0.1f;

	void Start () {
		
	}

	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");

		float y = Input.GetAxisRaw ("Vertical");

		Vector3 direction = new Vector3 (x, y, 0).normalized;

		GetComponent<Transform> ().position = GetComponent<Transform> ().position + direction * speed;
	}
}
