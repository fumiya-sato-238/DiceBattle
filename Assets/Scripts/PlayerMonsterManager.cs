using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMonsterManager : MonoBehaviour
{
    [SerializeField] Text PlayerMonsterHPText;
    [SerializeField] int PlayerMonsterMaxHP;
    [SerializeField] Text PlayerMonsterDPText;
    int PlayerMonsterHP;
    int PlayerMonsterDP;

    [SerializeField] EnemyMonsterManager enemyMonsterManager;

    public void init(){
        PlayerMonsterHP = PlayerMonsterMaxHP;
        PlayerMonsterHPText.text = string.Format("HP:{0}/{1}",PlayerMonsterHP,PlayerMonsterMaxHP);
        PlayerMonsterDP = 0;
        PlayerMonsterDPText.text = string.Format("DP:{0}",PlayerMonsterDP);
    }

    //サイコロの目の値によって攻撃が変わる
    public void attack(int diceNumber)
    {
        switch (diceNumber)
        {
            case 1:
                Debug.Log("1が出た");
                enemyMonsterManager.damage(1);
                break;
            case 2:
                Debug.Log("2が出た");
                enemyMonsterManager.damage(2);
                break;
            case 3:
                Debug.Log("3が出た");
                enemyMonsterManager.damage(3);
                break;
            case 4:
                Debug.Log("4が出た");
                enemyMonsterManager.damage(4);
                break;
            case 5:
                Debug.Log("5が出た");
                enemyMonsterManager.damage(5);
                break;
            case 6:
                Debug.Log("6が出た");
                enemyMonsterManager.damage(6);
                break;
        }
        PlayerMonsterDP += diceNumber;
        PlayerMonsterDPText.text = string.Format("DP:{0}",PlayerMonsterDP);
    }

    public void damage(int damageValue)
    {
        PlayerMonsterHP -= damageValue;
        PlayerMonsterHPText.text = string.Format("HP:{0}/{1}",PlayerMonsterHP,PlayerMonsterMaxHP);
    }

}
