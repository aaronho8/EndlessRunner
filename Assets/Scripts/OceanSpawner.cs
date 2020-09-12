using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OceanSpawner : MonoBehaviour
{

    public List<GameObject> oceans;
    private float offset = 100f;


    // Start is called before the first frame update
    void Start()
    {
        if (oceans != null && oceans.Count > 0){
            oceans = oceans.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveOcean(){
        GameObject movedOcean = oceans[0];
        oceans.Remove(movedOcean);
        float newZ = oceans[oceans.Count - 1].transform.position.z + offset;
        movedOcean.transform.position = new Vector3(0,0,newZ);
        oceans.Add(movedOcean);
    }

    
}
