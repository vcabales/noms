using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {
    public Sprite[] spriteList;
    public float maxX;
    public float minX;
    public GameObject Food;
    public Transform foodTransform;
    public static System.Random rand = new System.Random();
    public float timer = 1f;

    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0f) {
            SpawnFood();
            timer = 1f;
        }
            
	}
    void SpawnFood() {
        var cam = Camera.main;
        //cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane)); // top right
        var tryThis = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.nearClipPlane)); // top left
        Vector2 spawnPosition = new Vector2(Random.Range(minX, maxX), tryThis.y); 
        if (Food == null) {
            Debug.Log(Resources.Load("./Prefabs/Food"));
            Food = Resources.Load("Prefabs/Food") as GameObject;
        }
            
        Debug.Log(Food);
        var f = Instantiate(Food);
        f.transform.position = spawnPosition;
        int r = rand.Next(0,spriteList.Length);
        f.GetComponent<SpriteRenderer>().sprite = spriteList[r];

    }
}
