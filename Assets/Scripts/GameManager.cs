using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerMonsterManager playerMonsterManager;
    [SerializeField] EnemyMonsterManager enemyMonsterManager;
    [SerializeField] Text TurnCountText;
    int turnCount;
    [SerializeField] GameObject diceActionPanel;
    [SerializeField] GameObject rollButton;
    // Start is called before the first frame update
    void Start()
    {
        diceActionPanel.SetActive(false);
        turnCount = 1;
        TurnCountText.text = string.Format("Turn:{0}",turnCount);
        playerMonsterManager.init();
        enemyMonsterManager.init();
    }

    public void OnRollButton()
    {
        diceActionPanel.SetActive(true);
        rollButton.SetActive(false);
        playerMonsterManager.attack(getRandom(7));
        enemyMonsterManager.attack();
        TurnCountText.text = string.Format("Turn:{0}",++turnCount);
    }

    int getRandom(int max)
    {
        return Random.Range(1,max);
    }

}
