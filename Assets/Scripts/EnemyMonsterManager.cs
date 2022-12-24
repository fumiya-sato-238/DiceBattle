using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMonsterManager : MonoBehaviour
{
    [SerializeField] Text EnemyMonsterHPText;
    [SerializeField] int EnemyMonsterMaxHP;
    int EnemyMonsterHP;

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
        EnemyMonsterHPText.text = string.Format("HP:{0}/{1}",EnemyMonsterHP,EnemyMonsterMaxHP);
    }
}
