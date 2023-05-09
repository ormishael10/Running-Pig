using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class TileSpawner : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public Transform player;
    float SpawnY;
    float tileLength;
    int amountOfTiles;
    
    void Start()
    {
        SpawnY = 0f;
        tileLength = 10f;
        amountOfTiles = 2;

        for(int i = 0; i < amountOfTiles; i++)
        {
            SpawnTiles();
            
        }

    }

    
    void Update()
    {
        if(player.position.y > (SpawnY - amountOfTiles * tileLength))
        {
            SpawnTiles();
        }
    }

    void SpawnTiles(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefab[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector2.up * SpawnY;
        SpawnY += tileLength;
        Destroy(go, 12);
    }

    
}
