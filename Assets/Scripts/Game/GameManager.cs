using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SceneManager sceneManager;

    public CharacterDatabase _characterDB;
    private int selectedOption;
    private bool isAlive = true;
    void Start() {
        sceneManager = FindObjectOfType<SceneManager>();

        if(!PlayerPrefs.HasKey("selectedOption")) 
        {
            selectedOption = 0;

            SpawnPlayer(selectedOption);
            SpawnEnemy(false);
        }
        else
        {
            Load();
        }
        
        //UpdateCharacter(selectedOption);
        //SpawnEnemy(false);
    }
    public void SpawnEnemy(bool _isAlive)
    {
        int index = 0;

        if(_isAlive == false) {
        GameObject spawnEnemy = Instantiate(sceneManager._enemyList[index]) as GameObject;
        spawnEnemy.transform.position = sceneManager._enemySpawnPosition.position;
        }
    }

    public void SpawnPlayer(int _selectedOption)
    {
        GameObject spawnEnemy = Instantiate(sceneManager._playerList[_selectedOption]) as GameObject;
        spawnEnemy.transform.position = sceneManager._playerSpawnPosition.position;
    }

    /*private void UpdateCharacter(int selectedOption)
    {
        Character character = _characterDB.GetCharacter(selectedOption);
    }*/

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
        SpawnPlayer(selectedOption);
        SpawnEnemy(false);
    }
}
