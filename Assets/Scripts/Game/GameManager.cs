using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SceneManager sceneManager;

    public CharacterDatabase _characterDB;
    private int selectedOption;
    //private bool _isAlive = true;
    void Start() {
        sceneManager = FindObjectOfType<SceneManager>();

        if(!PlayerPrefs.HasKey("selectedOption")) 
        {
            selectedOption = 0;

            SpawnPlayer(selectedOption);
            //SpawnEnemy(false);
        }
        else
        {
            Load();
        }
        
        //UpdateCharacter(selectedOption);
        //SpawnEnemy(true);
    }
    public void SpawnEnemy()
    {
        int index = Random.Range(0,4);

        if(!gameObject.CompareTag("Enemy")) {
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
        SpawnEnemy();
    }
}
