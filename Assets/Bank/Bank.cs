using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField ]int currentBalance;
    
    [SerializeField] TextMeshProUGUI goldText;


    public int CurrentBalance { get { return currentBalance; } }

    private void Awake()
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();

        if (currentBalance < 0)
        {
            ReloadScene();
        }
        
    }

    void UpdateDisplay()
    {
        goldText.text = "Gold: " + currentBalance.ToString();
    }

    void ReloadScene()
    {
        Scene currentScene =SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
