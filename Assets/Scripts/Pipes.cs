using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5.0f;
    private float leftEdge;
    private void Start()
    {
        leftEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).x - 5f;
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
