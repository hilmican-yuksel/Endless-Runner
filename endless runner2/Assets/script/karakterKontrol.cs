
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class karakterKontrol : MonoBehaviour
{
    float hareketV;
    public float karakterHızı = 10f;
    public spawnManager _spawnManager;
    public Animator animasyon;
    public Text altınTexti;
    private int altın;
    float hareketH;
    bool düştü;


    public Text gameOaltın;

    public GameObject bitis;

    bool sağ;
    bool sol;

    void Start() 
    {
        altınTexti.text = altın.ToString();
      
       
    }

 
    void Update()
    {
        if (!düştü)
        {
            hareketH = Input.GetAxis("Horizontal") * karakterHızı;
            hareketV = 9f + spawnManager.hızlan;

        }
        gameOaltın.text = altın.ToString();
        //Input.GetAxis("Horizontal")
        //Input.GetAxis("Mouse X")

        if(Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if(parmak.deltaPosition.x > 50.0f)
            {

                sağ = true;
                sol = false;
            }
            if (parmak.deltaPosition.x < -50.0f)
            {

                sağ = false;
                sol = true;
            }


            if(sağ == true)
            {

                hareketH = 6f;

            }

            if (sol == true)
            {

                hareketH = -6f;

            }
            //sag 3.07
            //sol -2.2

        }


        transform.Translate(new Vector3(hareketH, 0, hareketV) * Time.deltaTime);


    }


    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "spawnTriger")
        {
            _spawnManager.SpawnTriggerEntered();

        }
        if (other.tag == "coin")
        {

            altın++;
            altınTexti.text = altın.ToString();
            Destroy(other.gameObject);
            

        }

        if (other.tag == "bariyer1")
        {
            Debug.Log("çarptı");
            hareketV = 0f;
            düştü = true;
            animasyon.SetBool("düştüMü", true);
            bitis.SetActive(true);
        }
    }
}
