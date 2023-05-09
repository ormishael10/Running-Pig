using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkSpawner : MonoBehaviour
{
    Transform player;
    float randomX;
    float randomY;
    public GameObject Pork;
    
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        randomX = Random.Range(-1.75f, 1.66f);
        randomY = Random.Range(-4.44f, 4.86f);
        Instantiate(Pork, new Vector2(transform.position.x + randomX,transform.position.y + randomY), Pork.transform.rotation);
        
        //Instantiate(Pork, new Vector2(transform.position.x + randomX, transform.position.y + randomY), Pork.transform.rotation);
    }

   
    void Update()
    {
        
        
    }
}
