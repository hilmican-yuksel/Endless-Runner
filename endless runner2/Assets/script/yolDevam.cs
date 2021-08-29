using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class yolDevam : MonoBehaviour
{//road spawn
    public List<GameObject> yollar;
    private float offset = 33;



    void Start()
    {
        if(yollar != null & yollar.Count > 0)
        {
            yollar = yollar.OrderBy(r => r.transform.position.z).ToList();

        }
    }

   
    public void MoveRoad()
    {
        GameObject moveRoad = yollar[0];
        yollar.Remove(moveRoad);
        float newZ = yollar[yollar.Count - 1].transform.position.z + offset;
        moveRoad.transform.position = new Vector3(0, 0, newZ);
        yollar.Add(moveRoad);

    }
}
