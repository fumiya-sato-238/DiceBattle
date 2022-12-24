using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMonsterManager : MonoBehaviour
{
    [SerializeField] Text PlayerMonsterHPText;
    [SerializeField] int PlayerMonsterMaxHP;

    public void init(){
        int PlayerMonsterHP = PlayerMonsterMaxHP;
        PlayerMonsterHPText.text = string.Format("HP:{0}/{1}",PlayerMonsterHP,PlayerMonsterMaxHP);
    }

    //サイコロの目の値によって攻撃が変わる
    public void attack(int diceNumber)
    {
        switch (diceNumber)
        {
            case 1:
                Debug.Log("1が出た");
                break;

        }
    }

}
