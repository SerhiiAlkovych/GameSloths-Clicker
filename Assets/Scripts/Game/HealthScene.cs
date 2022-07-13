using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScene : MonoBehaviour
{
    private int maxMonsterHealth = 100;
    private int monsterHealth = 100;

    EnemyAward enemyAward;
    AwardManager awardManager;

    SceneManager sceneManager;

    void Start() {
        enemyAward = GetComponent<EnemyAward>();
        awardManager = FindObjectOfType<AwardManager>();
        sceneManager = FindObjectOfType<SceneManager>();
    }

    void Update() {
        sceneManager._monsterHealth.value = monsterHealth;
        sceneManager._monsterHealth.maxValue = maxMonsterHealth;
    }

    // Start is called before the first frame update

    public void GetHit(int _damage)
    {
        int _health = monsterHealth - _damage;

        if(_health <= 0) 
        {
            awardManager.getGold(100,false); // enemyAward.EnemyGold
            Destroy(gameObject);
        }
        monsterHealth = _health;
    }


}
