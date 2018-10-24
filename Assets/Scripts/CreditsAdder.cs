using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsAdder : MonoBehaviour
{

    private Text creditsAmountLabel;
    private int creditsAmount;

    void Start()
    {
        creditsAmount = 0;
        creditsAmountLabel = GameObject.Find("YourBalanceText").GetComponent<Text>();
    }


    void Update()
    {
        creditsAmountLabel.text = creditsAmount.ToString();
    }

    public void add5Credits()
    {
        creditsAmount += 5;
    }

    public void add50Credits()
    {
        creditsAmount += 50;
    }

    public void add500Credits()
    {
        creditsAmount += 500;
    }
}
