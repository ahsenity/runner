using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objespawner : MonoBehaviour
{ 
private int lastSpawnX=30;
private int spawnInterval=23;
public List<GameObject> obstacles;

  public float spawnDelay = 1f; // Yeni obje spawn etme gecikmesi
    public float repeatInterval = 9f; // Tekrar eden spawn aralığı
    private bool isSpawning = true; // Spawn işlemi kontrolü

    void Start()
    {
        StartCoroutine(SpawnRepeatedly());
    }

    IEnumerator SpawnRepeatedly()
    {
        yield return new WaitForSeconds(spawnDelay); // Başlangıç gecikmesi

        while (isSpawning)
        {
            SpawnObstacles(); // Obje spawn et

            yield return new WaitForSeconds(repeatInterval); // Tekrar eden spawn aralığı
        }
    }


public void SpawnObstacles()
{
lastSpawnX -= spawnInterval;
if (Random.Range(0,1)==0){
GameObject obstacle = obstacles [Random.Range(0, obstacles.Count)];
var clone=Instantiate (obstacle, new Vector3(lastSpawnX, 0f, 0.03f), obstacle.transform.rotation); 

Destroy(clone, 20f);
}
}
}