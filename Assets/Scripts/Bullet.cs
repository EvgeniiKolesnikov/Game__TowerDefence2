using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed, damage;

	private void Start()
	{
		Destroy(gameObject, 2);
	}

	private void Update()
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
