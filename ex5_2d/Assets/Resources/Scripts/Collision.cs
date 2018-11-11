using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("detecting collision");
        Debug.Log(other);
        //Destroy(gameObject);
        if (Time.time > 2f) {
            if (other.GetComponent<GuMovement>())
            {
                Destroy(other.gameObject);
            }
            if (other.GetComponent<GuMovement>() || other.GetComponent<PlayerController>())
                Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (gameObject != null) {
            var rb = GetComponent<Rigidbody2D>();
            Debug.Log(rb.transform.position);
            if (rb.transform.position.y < -10f)
            { // Figure out how to adjust this
                Debug.Log("here");
                if (gameObject)
                    Destroy(gameObject);
            }
        }
    }
}
