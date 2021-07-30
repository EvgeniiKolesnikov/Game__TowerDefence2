using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Transform[] points;

    private Transform currentPoint;
    private int index;
    private Vector3 direction;

    void Start()
    {
        index = 0;
        currentPoint = points[index];
    }

    void Update()
    {
        direction = currentPoint.position - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, Time.deltaTime * rotationSpeed, 0);

        transform.rotation = Quaternion.LookRotation(newDirection);
        transform.position = Vector3.MoveTowards(transform.position, currentPoint.position, Time.deltaTime * speed);

        if (transform.position == currentPoint.position) {
            index++;
            if (index >= points.Length) {
                Destroy(gameObject);
            } else {
                currentPoint = points[index];
            }
		}
    }
}
