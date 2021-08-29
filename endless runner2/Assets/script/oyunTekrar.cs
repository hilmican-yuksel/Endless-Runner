using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class oyunTekrar : MonoBehaviour
{
   public void tekrar()
    {
        spawnManager.hızlan = 0; 
        SceneManager.LoadScene(0);

    }
}
