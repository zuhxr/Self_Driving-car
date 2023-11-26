using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedPositionSphere : MonoBehaviour
{
    void Start()
    {
        // Call a method to set the initial random spawn position
        SetRandomSpawnPosition();
    }

    void Update()
    {
        // You can perform any other actions here based on your project requirements
    }

   void SetRandomSpawnPosition()
{
    // Define the base name of the spawn locations
    string spawnLocationBaseName = "SpawnPoint";

    // Number of spawn locations
    int numSpawnLocations = 4;

    // Choose a random index for the spawn position
    int randomIndex = Random.Range(1, numSpawnLocations + 1);

    // Construct the name of the randomly chosen spawn location
    string spawnLocationName = $"{spawnLocationBaseName}({randomIndex})";

    // Debug.Log to check the constructed spawnLocationName
    Debug.Log($"Spawn Location Name: {spawnLocationName}");

    // Find the spawn location GameObject using its name
    GameObject spawnLocation = GameObject.Find(spawnLocationName);

    // If the spawn location is found, set the position of the sphere to that location
    if (spawnLocation != null)
    {
        transform.position = spawnLocation.transform.position;
    }
    else
    {
        Debug.LogError("Spawn location not found!");
    }
}

}