using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] gameObjects;

    private Vector3 spawnPos = new Vector3(-6,0,0);

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        /*foreach(GameObject shape in gameObject)
        {
            
            Instantiate(shape, spawnPos, shape.transform.rotation);
            spawnPos += new Vector3(3, 0, 0);
        }*/
        for(int i = 0; i < 5; i++)
        {
            int randomShape = Random.Range(0, gameObjects.Length);

            Instantiate(gameObjects[randomShape], spawnPos, gameObjects[randomShape].transform.rotation);
            spawnPos += new Vector3(3, 0, 0);
        }
    }
}
