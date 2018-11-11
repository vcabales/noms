using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        if (other.GetComponent<GuMovement>()) {
            Destroy(other.gameObject);
        }
    }
    //private void Update()
    //{
    //    var rb = GetComponent<Rigidbody2D>();
    //    Debug.Log(rb.transform.position);
    //    if (rb.transform.position.y < -9f) { // Figure out how to adjust this
    //        Destroy(this.gameObject);
    //    }
    //}
}
