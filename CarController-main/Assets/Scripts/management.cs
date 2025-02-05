using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class management : MonoBehaviour
{
	public GameObject otherGameObject;
	public Canvas mainMenu, upgrades, deathScreen, inGame;

	public int GameState = 0; // 0 = main menu, 1 = ingame, 2 = upgrades, 3 = deathscreen

	public int kills = 0;

	// Start is called before the first frame update
	void Start()
	{
		mainMenu.enabled = false;
		upgrades.enabled = false;
		deathScreen.enabled = false;	
		inGame.enabled = false;
		ManageUI(0);
		
		
		
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
		
		if (GameState == 1)
		{
			if(Input.GetKeyDown("u") || Input.GetKeyDown(KeyCode.LeftControl))
			{
				ManageUI(2);	
			}		

		}

		
		
	}

	public void ResetGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	void ManageUI(int gameState)
	{
		if (gameState == 0)
		{
			GameState = 0;
			mainMenu.enabled = true;
			upgrades.enabled = false;
			deathScreen.enabled = false;	
			inGame.enabled = false;
			Time.timeScale = 0;
		}
		else if (gameState == 1)
		{
			GameState = 1;
			mainMenu.enabled = false;
			upgrades.enabled = false;
			deathScreen.enabled = false;
			inGame.enabled = true;
			Time.timeScale = 1f;
		}
		else if (gameState == 2)
		{
			GameState = 2;
			mainMenu.enabled = false;
			upgrades.enabled = true;
			deathScreen.enabled = false;
			inGame.enabled = false;		
			Time.timeScale = 0;
		}		
		else if (gameState == 3)
		{
			GameState = 3;
			mainMenu.enabled = false;
			upgrades.enabled = false;
			deathScreen.enabled = true;
			inGame.enabled = false;	
			Time.timeScale = 0;		
		}
	}
	
	public void StartGameBtn()
	{
		ManageUI(1);
	}

}
