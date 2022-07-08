using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase _characterDB;
    public Image artworkSprite;

    public Text _characterNameText;
    public Text _characterGoldText;
    public Text _characterAttackText;

    private int selectedOption = 0;
    private int playerID;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("selectedOption")) {
            selectedOption = 0;
            playerID = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption ++;

        if(selectedOption >= _characterDB.CharacterCount) 
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption --;

        if(selectedOption < 0) 
        {
            selectedOption = _characterDB.CharacterCount -1;
        }
        UpdateCharacter(selectedOption);
        Save();
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = _characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character._characterSprite;
        _characterNameText.text = character._characterName;
        _characterGoldText.text = character._characterGold;
        _characterAttackText.text = character._characterAttack;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
        playerID = PlayerPrefs.GetInt("playerID");
    }
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
        PlayerPrefs.SetInt("playerID", playerID);
    }

    public void LoadScene(int _sceneID)
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneID);
    }
}
