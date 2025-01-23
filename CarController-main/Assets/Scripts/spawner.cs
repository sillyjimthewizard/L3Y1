using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private bool cansalt = true;
    public int salty =5;

    // Start is called before the first frame update

    public GameObject cubePrefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && salty > 0)
        {

            salty = (salty - 1);
            Instantiate(cubePrefab, transform.position, Quaternion.identity);

        }
    
        if (salty > 5)
        {
            salty = (5);
        }
    }

    
}
