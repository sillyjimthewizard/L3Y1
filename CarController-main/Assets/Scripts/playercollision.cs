using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    management manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<management>();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag ("snail"))
        {
            manager.gameState = 3;
            
        }

    }
}
