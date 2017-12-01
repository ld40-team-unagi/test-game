using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmmitter : MonoBehaviour {
	public GameObject enemy;

	IEnumerator Start ()
	{
		while (true) {
			//Quaternion rotation = transform.rotation; 
			Instantiate (enemy, transform.position+(new Vector3(Random.Range(-2.7f,2.7f),0f,0f)), Quaternion.Euler(0, 0, 180));
			yield return new WaitForSeconds (5.0f);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

}
