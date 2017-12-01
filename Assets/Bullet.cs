using UnityEngine;

public class Bullet : MonoBehaviour
{
	public int speed = 2;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.up.normalized * speed;
	}
}