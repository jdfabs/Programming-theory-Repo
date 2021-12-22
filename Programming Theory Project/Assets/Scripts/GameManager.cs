using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    [SerializeField] private GameObject[] spawnedShapes = new GameObject[5];

    private Vector3 spawnPos = new Vector3(-6, 0, 0);



    public void Spawn()
    {
        for (int i = 0; i < spawnedShapes.Length; i++)
        {
            Destroy(spawnedShapes[i]);
        }
        Vector3 SpawnPos = spawnPos;
        for (int i = 0; i < 5; i++)
        {
            int randomShape = Random.Range(0, gameObjects.Length);
            spawnedShapes[i] = Instantiate(gameObjects[randomShape], SpawnPos, gameObjects[randomShape].transform.rotation);
            SpawnPos += new Vector3(3, 0, 0);
        }
    }
}
