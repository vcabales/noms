using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    // Use this for initialization
	void Awake () {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (ScoreManager.score >= 5)
            MusicSource.Stop();
	}
}
