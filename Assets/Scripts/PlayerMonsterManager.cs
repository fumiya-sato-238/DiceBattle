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

    [SerializeField] GameObject resultPanel;
    [SerializeField] Text resultText;

    //攻撃ダメージの倍率
    int powerValue = 1;

    [SerializeField] EnemyMonsterManager enemyMonsterManager;

    public void init(){
        PlayerMonsterHP = PlayerMonsterMaxHP;
        PlayerMonsterHPText.text = string.Format("HP:{0}/{1}",PlayerMonsterHP,PlayerMonsterMaxHP);
        PlayerMonsterDP = 0;
        PlayerMonsterDPText.text = string.Format("DP:{0}",PlayerMonsterDP);
    }

    //サイコロの目の値によって攻撃が変わる
    // public void attack(int diceNumber)
    // {
    //     PlayerMonsterDP += diceNumber;
    //     PlayerMonsterDPText.text = string.Format("DP:{0}",PlayerMonsterDP);
    // }
    public void diceAction(int diceIndex)
    {
        switch(diceIndex)
        {
            case 1:
                Debug.Log("1を選択");
                powerValue = 2;
                break;
            case 2:
                Debug.Log("2を選択");
                enemyMonsterManager.damage(2*powerValue);
                powerValue = 1;
                break;
            case 3:
                Debug.Log("3を選択");
                heal(5);
                break;
            case 4:
                Debug.Log("4を選択");
                enemyMonsterManager.damage(4*powerValue);
                powerValue = 1;
                break;
            case 5:
                Debug.Log("5を選択");
                enemyMonsterManager.damage(5*powerValue);
                powerValue = 1;
                break;
            case 6:
                Debug.Log("6を選択");
                enemyMonsterManager.damage(6*powerValue);
                powerValue = 1;
                break;
        }
    }

    public void damage(int damageValue)
    {
        PlayerMonsterHP -= damageValue;
        if(PlayerMonsterHP <= 0)
        {
            PlayerMonsterHP = 0;
        }
        PlayerMonsterHPText.text = string.Format("HP:{0}/{1}",PlayerMonsterHP,PlayerMonsterMaxHP);
        checkAlive();
    }
    public void heal(int healValue)
    {
        PlayerMonsterHP += healValue;
        //HP上限を越えて回復を防ぐ
        if(PlayerMonsterHP >= PlayerMonsterMaxHP)
        {
            PlayerMonsterHP = PlayerMonsterMaxHP;
        }
        PlayerMonsterHPText.text = string.Format("HP:{0}/{1}",PlayerMonsterHP,PlayerMonsterMaxHP);
    }

    public void addTurnDP(int diceIndex)
    {
        //Dice振った時のDPの追加
        PlayerMonsterDP += diceIndex;
        PlayerMonsterDPText.text = string.Format("DP:{0}",PlayerMonsterDP);
    }

    void checkAlive()
    {
        if(PlayerMonsterHP <= 0)
        {
            resultPanel.SetActive(true);
            resultText.text = "YOU LOSE!";
            Debug.Log("Player Lose!");
        }
    }

}
