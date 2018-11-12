using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour {
    public static int lives;
    public GameObject[] sprites;
    private int pastLives;
    public AudioSource MusicSource1;
    public AudioSource MusicSource2;
    public AudioClip MusicClip;
    public AudioClip LosingClip;
    private bool firstPlay;

    void Start () {
        MusicSource1.clip = MusicClip;
        MusicSource2.clip = LosingClip;
        firstPlay = true;
        sprites = new GameObject[3];
        var s1 = Resources.Load("Prefabs/LifeSprite") as GameObject;
        var s2 = Resources.Load("Prefabs/LifeSprite1") as GameObject;
        var s3 = Resources.Load("Prefabs/LifeSprite2") as GameObject;
        // Add 1f to original LifeSprite prefab's position
        sprites[0] = Instantiate(s1);
        sprites[1] = Instantiate(s2);
        sprites[2] = Instantiate(s3);
        for (int j = 0; j < 3;j++) {
            //sprites[j].GetComponent<CircleCollider2D>().enabled = false;
            Debug.Log(sprites[j]);
        }
        lives = 2;
        pastLives = lives;
	}
    private void Update()
    {
        if (lives < 0)
        {
            if (firstPlay)
            {
                MusicSource2.PlayOneShot(LosingClip);
                Destroy(sprites[0]);
                firstPlay = false;
                SceneManager.LoadScene("LoseScene");
            }
        }
        if (pastLives > lives) {
            Destroy(sprites[pastLives]);
            pastLives = lives;
            MusicSource1.PlayOneShot(MusicClip);
        }

    }

}
