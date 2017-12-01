using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider c)
	{
		Debug.Log (c.tag);
		if (c.tag == "PlayerBullet" || c.tag == "EnemyBullet" || c.tag == "Enemy") {
			Destroy (c.gameObject);
		}
	}

}
