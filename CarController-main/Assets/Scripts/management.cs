using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class management : MonoBehaviour
{

    public Enemy snailscript;

    // Start is called before the first frame update
    void Start()
    {
      snailscript = GameObject.Find("Enemy").GetComponent<enemymoveplease>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
