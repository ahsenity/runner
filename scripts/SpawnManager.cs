using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{ 
    YolSpawner yolSpawner;
    objespawner objespawner_;
    void Start()
    {
        yolSpawner= GetComponent<YolSpawner>();
       objespawner_= GetComponent<objespawner>();

    }
    
    void Update()
    {
        
    }
    public void SpawnTriggerEntered(){
        yolSpawner.moveRoad();
        objespawner_.SpawnObstacles();
    }
}
