using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour {
	public float speed = 0.1f;
	public float life = 10f;

	public void Move(Vector3 direction){
		GetComponent<Transform> ().position = GetComponent<Transform> ().position + direction * speed;
	}

	public void Shot (Transform origin, GameObject bullet)
	{
		Instantiate (bullet, origin.position, origin.rotation);
	}

}
