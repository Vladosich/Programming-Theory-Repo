using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] animals;

    public GameManager gameManagerScript;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("Animal") && gameManagerScript.isGameActive)
        {
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosinion = new Vector3(0, 0, 0);
        Instantiate(animals[animalIndex], spawnPosinion, Quaternion.Euler(0,0,0));
    }
}
