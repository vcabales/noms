using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "food") && Time.time > 3f) {
            Destroy(other.gameObject);
            if (LifeManager.lives >= 0)
                LifeManager.lives -= 1;
        }
    }
}
