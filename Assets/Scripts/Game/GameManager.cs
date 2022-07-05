using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SceneManager sceneManager;

    private bool isAlive = false;
    void Start() {
        sceneManager = FindObjectOfType<SceneManager>();
        SpawnEnemy(true);
    }
    public void SpawnEnemy(bool isAlive)
    {
        int index = 0;

        if(isAlive == true) {
        GameObject spawnEnemy = Instantiate(sceneManager._enemyList[index]) as GameObject;
        spawnEnemy.transform.position = sceneManager._enemySpawnPosition.position;
        }

    }
}
