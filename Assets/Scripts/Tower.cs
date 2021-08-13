using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float radius, fireDelay, damage;
    public LayerMask enemyLayer;
    public Transform bulletPrefab;

    float timeToFire;
    Transform gun, enemy, firePoint;

    private void Start() {
        timeToFire = fireDelay;
        gun = transform.GetChild(0);
        firePoint = gun.GetChild(0);
    }

    private void Update()
    {
        if (timeToFire > 0) {
            timeToFire -= Time.deltaTime;
        } else if (enemy) {
            Fire();
        } 

        if (enemy) {
            Vector3 lookAt = enemy.position;
            lookAt.y = gun.position.y;
            gun.rotation = Quaternion.LookRotation(lookAt - gun.position);
            if (Vector3.Distance(transform.position, enemy.position) > radius) {
                enemy = null;
            }
        } else if (enemy == null) {
            Collider[] coll = Physics.OverlapSphere(transform.position, radius, enemyLayer);
            if (coll.Length > 0) {
                enemy = coll[0].transform;
            }
        }
    }

	void Fire() {
        Transform bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.LookAt(enemy.GetChild(0));
        bullet.GetComponent<Bullet>().damage = damage;
        timeToFire = fireDelay;
    }
}
