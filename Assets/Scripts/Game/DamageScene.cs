using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScene : MonoBehaviour
{
    private int characterDamage = 10;
    // Start is called before the first frame update

    void OnMouseDown() {
        GetComponent<Animator>().SetBool("isHurt", true);
        FindObjectOfType<HealthScene>().GetHit(characterDamage);
    }

    void OnMouseUp() {
        GetComponent<Animator>().SetBool("isHurt", false);
    }
}
