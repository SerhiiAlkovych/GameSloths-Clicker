using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [Header("Text references")]
    public Text _playerGoldText;

    [Header("GameObjects references")]
    public GameObject _goldPrefab;
    public GameObject[] _enemyList;

    [Header("Transform references")]
    public Transform _enemySpawnPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerGoldText.text = FindObjectOfType<AwardManager>().PlayerGold.ToString();
    }


}
