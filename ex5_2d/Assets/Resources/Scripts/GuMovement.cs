using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuMovement : MonoBehaviour {
    public float speed;

    private Rigidbody2D rb;
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
	}

    private void Update()
    {
        //Debug.Log(Screen.height);
        //if (Camera.main.transform.position.y+5f < rb.position.y) {
        //    Destroy(gameObject);
        //}
        if (!GetComponent<Renderer>().isVisible) {
            Destroy(gameObject);
        }
    }
}
