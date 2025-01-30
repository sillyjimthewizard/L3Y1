using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemymoveplease : MonoBehaviour
{
    // Start is called before the first frame update

     [SerializeField] private Transform movePositionTransform;

    public AudioSource deathnoise;
    

     private NavMeshAgent navMeshAgent;
     


    private void Awake ()
    {
        movePositionTransform = GameObject.Find("Car").gameObject.transform;
        
        
        
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
        //gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = target.transform.position;
 


    }

    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag ("salt"))
        {
           deathnoise.Play();
           //gameObject.SetActive(false);
           //Destroy(gameObject);
           Invoke("destroyObject", 0.39f);
           
           
        }

    }

    public void destroyObject ()
    {
        Destroy(gameObject);

    }



}
