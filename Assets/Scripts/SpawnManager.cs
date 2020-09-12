using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{


    RoadSpawner roadSpawner;
    OceanSpawner oceanSpawner;


    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        oceanSpawner = GetComponent<OceanSpawner>();
    }

   



    public void SpawnTriggerEntered(){
        roadSpawner.MoveRoad();
        oceanSpawner.MoveOcean();
    }
}
