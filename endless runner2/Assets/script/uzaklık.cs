using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class uzaklık : MonoBehaviour
{

    private GameObject player;

    public Text uiDistance;
    public Text gameOuzaklık;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        int uzaklık = Mathf.RoundToInt(player.transform.position.z);
        gameOuzaklık.text = uzaklık.ToString();
        uiDistance.text = uzaklık.ToString() + "m";

    }
}
