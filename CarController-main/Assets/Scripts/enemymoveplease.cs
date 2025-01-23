using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemymoveplease : MonoBehaviour
{
    // Start is called before the first frame update

     [SerializeField] private Transform movePositionTransform;

     private NavMeshAgent navMeshAgent;
     


    private void Awake ()
    {
        
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
        


    }

    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag ("salt"))
        {
           Destroy(gameObject);
           Debug.Log(gameObject + " hasn't beed destroyed yet!");
        }

    }

}
