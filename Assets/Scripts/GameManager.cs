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
    [SerializeField] GameObject skillButton;
    [SerializeField] GameObject skillPanel;
    [SerializeField] Button diceActionButton_1;
    [SerializeField] Button diceActionButton_2;
    [SerializeField] Button diceActionButton_3;
    [SerializeField] Button diceActionButton_4;
    [SerializeField] Button diceActionButton_5;
    [SerializeField] Button diceActionButton_6;

    // Start is called before the first frame update
    void Start()
    {
        diceActionPanel.SetActive(false);
        skillPanel.SetActive(false);
        turnCount = 1;
        TurnCountText.text = string.Format("Turn:{0}",turnCount);
        playerMonsterManager.init();
        enemyMonsterManager.init();
    }

    //-------------ボタン関連--------------------
    public void OnRollButton()
    {
        diceActionPanel.SetActive(true);
        rollButton.SetActive(false);
        skillButton.SetActive(false);

        int diceIndex = getRandom(7);
        viewDiceActionButton(diceIndex);
        playerMonsterManager.addTurnDP(diceIndex);

    }

    //選択したDiceボタンの数のアクションを呼び出す
    public void OnDiceActionButton_1()
    {
        playerMonsterManager.diceAction(1);
        enemyMonsterManager.attack();
        afterDiceAction();
    }
    public void OnDiceActionButton_2()
    {
        playerMonsterManager.diceAction(2);
        enemyMonsterManager.attack();
        afterDiceAction();
    }
    public void OnDiceActionButton_3()
    {
        playerMonsterManager.diceAction(3);
        enemyMonsterManager.attack();
        afterDiceAction();
    }
    public void OnDiceActionButton_4()
    {
        playerMonsterManager.diceAction(4);
        enemyMonsterManager.attack();
        afterDiceAction();
    }
    public void OnDiceActionButton_5()
    {
        playerMonsterManager.diceAction(5);
        enemyMonsterManager.attack();
        afterDiceAction();
    }
    public void OnDiceActionButton_6()
    {
        playerMonsterManager.diceAction(6);
        enemyMonsterManager.attack();
        afterDiceAction();
    }

    public void OnSkillButton()
    {
        skillPanel.SetActive(true);
    }
    public void OnSkillExitButton()
    {
        skillPanel.SetActive(false);
    }

    //-------------ここまでボタン関連--------------------

    //DiceAction後の処理
    void afterDiceAction()
    {
        TurnCountText.text = string.Format("Turn:{0}",++turnCount);
        diceActionPanel.SetActive(false);
        rollButton.SetActive(true);
        skillButton.SetActive(true);
    }

    //乱数生成（1〜max-1）
    int getRandom(int max)
    {
        return Random.Range(1,max);
    }

    //サイコロの目によって選択可能なボタンをアクティブ化
    void viewDiceActionButton(int diceIndex)
    {
        //一度ボタンを全てアクティブ化
        diceActionButton_1.interactable = true;
        diceActionButton_2.interactable = true;
        diceActionButton_3.interactable = true;
        diceActionButton_4.interactable = true;
        diceActionButton_5.interactable = true;
        diceActionButton_6.interactable = true;
        if(diceIndex == 1)
        {
            diceActionButton_2.interactable = false;
            diceActionButton_3.interactable = false;
            diceActionButton_4.interactable = false;
            diceActionButton_5.interactable = false;
            diceActionButton_6.interactable = false;
        }
        else if(diceIndex == 2)
        {
            diceActionButton_3.interactable = false;
            diceActionButton_4.interactable = false;
            diceActionButton_5.interactable = false;
            diceActionButton_6.interactable = false;
        }
        else if(diceIndex == 3)
        {
            diceActionButton_4.interactable = false;
            diceActionButton_5.interactable = false;
            diceActionButton_6.interactable = false;
        }
        else if(diceIndex == 4)
        {
            diceActionButton_5.interactable = false;
            diceActionButton_6.interactable = false;
        }
        else if(diceIndex == 5)
        {
            diceActionButton_6.interactable = false;
        }
        else
        {

        }
    }

}
