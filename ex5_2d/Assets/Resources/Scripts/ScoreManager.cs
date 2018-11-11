using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public Transform t;

    Text text;
    private void Awake()
    {
        Camera cam = Camera.main;
        var tryThis = cam.ViewportToWorldPoint(new Vector3(0, 1, 0)); // top left?
        //t.position = tryThis;
        text = GetComponent<Text>();
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Noms: " + score;
    }
}
