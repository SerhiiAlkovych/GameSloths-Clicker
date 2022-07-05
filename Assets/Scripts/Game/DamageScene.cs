using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScene : MonoBehaviour
{
    private int characterDamage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown() {
        Debug.Log("GetHit"); // Will stay only for tests;
        GetComponent<Animator>().SetBool("isHurt", true);
        GetComponent<HealthScene>().GetHit(characterDamage);
    }

    void OnMouseUp() {
        GetComponent<Animator>().SetBool("isHurt", false);
    }
}
