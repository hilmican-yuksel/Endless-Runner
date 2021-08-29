using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    yolDevam yoldevam;
    engelOluştur engel;

    public static int hızlan=0;
    void Start()
    {
        yoldevam = GetComponent<yolDevam>();
        engel = GetComponent<engelOluştur>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        if(hızlan <= 24)
        {
            hızlan++;

        }
        
      
        engel.spawnObstacles();
        yoldevam.MoveRoad();
    }
 

}
