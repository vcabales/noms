using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Sprite Win;
    public Sprite Lose;
    public AudioSource MusicSource;
    public AudioClip MusicClip;
    private bool firstPlay;
    private bool firstLoss;
    private bool left;
    private bool right;

    private void Start()
    {
        MusicSource.clip = MusicClip;
        firstPlay = true;
        firstLoss = true;
        right = true;
        left = false;
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(gu, guTransform);
        }
        if ((ScoreManager.score >= 20) && firstPlay) {
            MusicSource.PlayOneShot(MusicClip);
            GetComponent<SpriteRenderer>().sprite = Win;
            firstPlay = false;
            SceneManager.LoadScene("WinScene"); // figure out how to wait to load scene, also not loading
        }
        if ((LifeManager.lives < 0) && firstLoss) {
            GetComponent<SpriteRenderer>().sprite = Lose;
            firstLoss = false;
        }
        if ((Input.GetAxis("Horizontal") > 0) && left) {
            right = true;
            left = false;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if ((Input.GetAxis("Horizontal") < 0) && right)
        {
            left = true;
            right = false;
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    private void FixedUpdate()
    {
        speed = 5f;
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
