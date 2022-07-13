using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardManager : MonoBehaviour
{
    private int playerGold = 11;

    public int PlayerGold { get{ return playerGold; }}

    SceneManager sceneManager;
    GameManager gameManager;
    
    public void getGold(int _gold, bool _isAlive)
    {
        playerGold += _gold;
        GameObject _goldObject = Instantiate(sceneManager._goldPrefab).gameObject;
        Destroy(_goldObject,2);
        gameManager.SpawnEnemy(_isAlive);
    }

    private void Start()
    {
        sceneManager = FindObjectOfType<SceneManager>();
        gameManager = FindObjectOfType<GameManager>();
    }
}
