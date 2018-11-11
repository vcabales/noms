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
                ScoreManager.score += 3;
            }
            if (other.GetComponent<PlayerController>())
                ScoreManager.score += 1;
            if (other.GetComponent<GuMovement>() || other.GetComponent<PlayerController>())
                Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (gameObject != null) {
            var rb = GetComponent<Rigidbody2D>();
            //Debug.Log(rb.transform.position);
            if (rb.transform.position.y < -10f)
            { // Figure out how to adjust this
                Debug.Log("here");
                if (gameObject)
                {
                    Destroy(gameObject);
                    if (LifeManager.lives > 0)
                        LifeManager.lives -= 1;

                }
            }
        }
    }
}
