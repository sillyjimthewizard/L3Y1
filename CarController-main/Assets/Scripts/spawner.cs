using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

   [Header ("ammo")]
    private bool cansalt = true;
    public int salty = (5);
    [Header ("audio")]
    public AudioSource saltnoise;
    

    // Start is called before the first frame update

    public GameObject cubePrefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && salty > 0)
        {

            salty = (salty - 1);
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
            saltnoise.Play();

        }
    
        if (salty > 5)
        {
            salty = (5);
        }
    }

    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag ("refill"))
        {
            salty = (5);
        }

    }
    
    
}
