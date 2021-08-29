using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelOluştur : MonoBehaviour
{
    private int spawnInterval = 18;
    private int lastSpawnZ = 28;
    private int spawnAmount = 4;


    public List<GameObject> engeller;

    void Start()
    {
        spawnObstacles();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void spawnObstacles()
    {

       


        for (int i = 0; i < spawnAmount; i++)
        {
          
            
                GameObject obstacle = engeller[Random.Range(0, engeller.Count)];
                Instantiate(obstacle, new Vector3(0, -0.15f, lastSpawnZ),obstacle.transform.rotation);
              lastSpawnZ += spawnInterval;

        }

    }
}
