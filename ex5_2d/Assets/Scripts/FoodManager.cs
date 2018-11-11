using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {
    public Sprite[] spriteList;
    public GameObject nom;
    public float maxX;
    public float minX;
    public GameObject Food;
    public Transform foodTransform;
    public static System.Random rand = new System.Random();
    public float timer = 2f;

    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0f) {
            SpawnFood();
            timer = 2f;
        }
            
	}
    void SpawnFood() {
        Debug.Log("Spawning food");
        var cam = Camera.main;
        //cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane)); // top right
        var tryThis = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.nearClipPlane)); // top left
        // Otherwise, put in 4.84 for y for now
        Vector2 spawnPosition = new Vector2(Random.Range(minX, maxX), 4.84f);
        //foodTransform.position = spawnPosition;
        var f = Instantiate(Food);
        f.transform.position = spawnPosition;
        int r = rand.Next(0,spriteList.Length-1);
        f.GetComponent<SpriteRenderer>().sprite = spriteList[r];

    }
}
