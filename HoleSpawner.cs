using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpawner : MonoBehaviour
{
    Transform player;
    float randomX;
    float randomY;
    public GameObject Hole;
    void Start()
    {

        player = GameObject.Find("Player").GetComponent<Transform>();
        randomX = Random.Range(-1.75f, 1.66f);
        randomY = Random.Range(-4.44f, 4.86f);
        Instantiate(Hole, new Vector2(transform.position.x + randomX, transform.position.y + randomY), Hole.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
