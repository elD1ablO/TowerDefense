using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldReward = 20;
    [SerializeField] int goldPenalty = 20;

    Bank bank;
    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }
    
    public void RewardGold()
    {
        if(bank == null) { return; }
        bank.Deposit(goldReward);
    }

    public void StealGold()
    {
        if (bank == null) { return; }
        bank.Withdraw(goldPenalty);
    }
}
