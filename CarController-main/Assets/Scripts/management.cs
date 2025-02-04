using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class management : MonoBehaviour
{
    public GameObject otherGameObject;

    public int GameState = 0; // 0 = main menu, 1 = game, 2 = upgrades, 3 = deathscreen

   public int kills = 0;

    // Start is called before the first frame update
    void Start()
    {
     enemymoveplease snailscript = otherGameObject.GetComponent<enemymoveplease>();
     //NavMeshAgent navmeshmove = otherGameObject.GetComponent<NavMeshAgent>();
    }

     
    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("k"))
        {
         ResetGame();
            
        }
    }

    public void ResetGame()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
