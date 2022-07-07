using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public Character[] _character;

    public int CharacterCount
    {
        get
        {
            return _character.Length;
        }
    }

    public Character GetCharacter(int _index)
    {
        return _character[_index];
    }
}
