using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag != "life") && (other.tag != "food")) {
            Debug.Log("detecting collision");
            Debug.Log(other);
            //Destroy(gameObject);
            if (Time.time > 2f)
            {
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

    }
}
