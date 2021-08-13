using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public Enemy enemyPrefab;
	public float timeToSpawn;
	public Transform[] points;
	public float mainHP = 100, increaseHP = 20;

	private float timer;

	private void Start()
	{
		timer = timeToSpawn;
	}

	private void Update()
	{
		timer -= Time.deltaTime;
		if (timer <=0) {
			Enemy enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
			enemy.points = points;
            enemy.SetHP(mainHP);
            mainHP += increaseHP;
			timer = timeToSpawn;
            
		}
	}
}
