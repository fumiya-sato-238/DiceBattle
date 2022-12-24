using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMonsterManager : MonoBehaviour
{
    [SerializeField] Text EnemyMonsterHPText;
    [SerializeField] int EnemyMonsterMaxHP;
    int EnemyMonsterHP;

    [SerializeField] GameObject resultPanel;
    [SerializeField] Text resultText;

    [SerializeField] PlayerMonsterManager playerMonsterManager;

    public void init(){
        EnemyMonsterHP = EnemyMonsterMaxHP;
        EnemyMonsterHPText.text = string.Format("HP:{0}/{1}",EnemyMonsterHP,EnemyMonsterMaxHP);
    }

    //サイコロの目の値によって攻撃が変わる
    public void attack()
    {
        Debug.Log("敵の攻撃！");
        playerMonsterManager.damage(3);
    }

    public void damage(int damageValue)
    {
        EnemyMonsterHP -= damageValue;
        if(EnemyMonsterHP <= 0)
        {
            EnemyMonsterHP = 0;
        }
        EnemyMonsterHPText.text = string.Format("HP:{0}/{1}",EnemyMonsterHP,EnemyMonsterMaxHP);
        checkAlive();
    }

    void checkAlive()
    {
        if(EnemyMonsterHP <= 0)
        {
            resultPanel.SetActive(true);
            resultText.text = "YOU WIN!!!";
            Debug.Log("Player Win!");
        }
    }
}
