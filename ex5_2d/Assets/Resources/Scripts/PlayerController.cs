using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary {
    public float xMin, xMax;
}

public class PlayerController : MonoBehaviour {
    public float speed;
    public Boundary boundary;

    public GameObject gu;
    public Transform guTransform;
    public float fireRate = 0.5f;
    public float nextFire = 0.5f;

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(gu, guTransform);
        }
    }

    private void FixedUpdate()
    {
        speed = 4f;
        boundary = new Boundary();
        boundary.xMax = Camera.main.transform.position.x+8f; // Figure out how to adjust this
        boundary.xMin = -Camera.main.transform.position.x-8f;
        float moveX = Input.GetAxis("Horizontal");
        Vector2 v = new Vector2(moveX, 0.0f);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = v * speed;
        Vector2 boundaryPos = new Vector2(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            -2.5f
        );
        rb.position = boundaryPos;
    }
}
