using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [Header("Text references")]
    public Text _playerGoldText;
    public Text _playerRubyText;

    [Header("GameObjects references")]
    public GameObject _goldPrefab;
    public GameObject[] _enemyList;
    public GameObject[] _playerList;
    public GameObject[] _wizzardHelperList;
    public GameObject[] _warriorHelperList;

    [Header("Transform references")]
    public Transform _enemySpawnPosition;
    public Transform _playerSpawnPosition;
    public Transform _wizzardHelperSpawnPosition;
    public Transform _warriorHelperSpawnPosition;

    [Header("Image references")]
    public Sprite[] _backgroundImageList;
    public Sprite[] _padsImageList;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerGoldText.text = FindObjectOfType<AwardManager>().PlayerGold.ToString();
    }


}
