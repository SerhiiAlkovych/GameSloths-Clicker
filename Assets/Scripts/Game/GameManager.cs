using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SceneManager sceneManager;

    public CharacterDatabase _characterDB;
    private int selectedOption = 0;
    private int playerID = 0;
    //private bool isAlive = false;
    void Start() {
        sceneManager = FindObjectOfType<SceneManager>();

        if(!PlayerPrefs.HasKey("playerID")) 
        {
            selectedOption = 0;
            playerID = 0;
            SpawnPlayer(playerID);
        }
        else
        {
            Load();
        }
        //UpdateCharacter(selectedOption);
        //SpawnEnemy(true);
    }
    /*public void SpawnEnemy(bool isAlive)
    {
        int index = 0;

        if(isAlive == true) {
        GameObject spawnEnemy = Instantiate(sceneManager._enemyList[index]) as GameObject;
        spawnEnemy.transform.position = sceneManager._enemySpawnPosition.position;
        }
    }*/

    public void SpawnPlayer(int _playerID)
    {
        GameObject spawnEnemy = Instantiate(sceneManager._playerList[_playerID]) as GameObject;
        spawnEnemy.transform.position = sceneManager._playerSpawnPosition.position;
    }

    /*private void UpdateCharacter(int selectedOption)
    {
        Character character = _characterDB.GetCharacter(selectedOption);
    }*/

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
        playerID = PlayerPrefs.GetInt("playerID");
        SpawnPlayer(playerID);
    }
}
