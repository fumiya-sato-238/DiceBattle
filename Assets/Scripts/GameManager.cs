using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerMonsterManager playerMonsterManager;
    [SerializeField] EnemyMonsterManager enemyMonsterManager;
    // Start is called before the first frame update
    void Start()
    {
        playerMonsterManager.init();
        enemyMonsterManager.init();
    }

    public void OnRollButton()
    {
        playerMonsterManager.attack(getRandom(7));
    }

    int getRandom(int max)
    {
        return Random.Range(1,max);
    }

}
