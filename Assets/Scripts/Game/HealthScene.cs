using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScene : MonoBehaviour
{
    private int maxMonsterHealth = 100;
    private int monsterHealth = 100;

    EnemyAward enemyAward;
    AwardManager awardManager;

    void Start() {
        enemyAward = GetComponent<EnemyAward>();
        awardManager = FindObjectOfType<AwardManager>();
    }
    // Start is called before the first frame update

    public void GetHit(int _damage)
    {
        int _health = monsterHealth - _damage;

        if(_health <= 0) 
        {
            bool isAlive = false;
            awardManager.getGold(enemyAward.EnemyGold,isAlive);
            Destroy(gameObject);
        }
        monsterHealth = _health;
    }


}
