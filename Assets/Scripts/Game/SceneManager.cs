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
    public GameObject[] _wizardHelperList;
    public GameObject[] _warriorHelperList;
    public GameObject[] _padsObjectImageList;

    [Header("Transform references")]
    public Transform _enemySpawnPosition;
    public Transform _playerSpawnPosition;
    public Transform _wizardHelperSpawnPosition;
    public Transform _warriorHelperSpawnPosition;

    [Header("Image references")]
    public Sprite[] _backgroundImageList;
    public Sprite[] _padsImageList;

    [Header("Slider References")]
    public Slider _monsterHealth;

    public int index = 0;

    // Update is called once per frame
    void Update()
    {
        //_playerGoldText.text = FindObjectOfType<AwardManager>().PlayerGold.ToString();
        BackgroundImageUpdate();
        PadsImageUpdate();
    }

    private void BackgroundImageUpdate()
    {
        GameObject.Find("Main_scene_panel").GetComponent<Image>().sprite = _backgroundImageList[index];
    }

    private void PadsImageUpdate()
    {
        foreach(var padsList in _padsObjectImageList) {
            padsList.GetComponent<Image>().sprite = _padsImageList[index];
        }
    }


}
