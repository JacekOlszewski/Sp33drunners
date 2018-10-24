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
        if (!PlayerPrefs.HasKey("Credits"))
        {
            PlayerPrefs.SetInt("Credits", 0);
        }
        creditsAmount = PlayerPrefs.GetInt("Credits");
        creditsAmountLabel = GameObject.Find("CreditsAmountText").GetComponent<Text>();
    }


    void Update()
    {
        creditsAmountLabel.text = creditsAmount.ToString();
    }

    public void add5Credits()
    {
        creditsAmount += 5;
        PlayerPrefs.SetInt("Credits", creditsAmount);
    }

    public void add50Credits()
    {
        creditsAmount += 50;
        PlayerPrefs.SetInt("Credits", creditsAmount);
    }

    public void add500Credits()
    {
        creditsAmount += 500;
        PlayerPrefs.SetInt("Credits", creditsAmount);
    }
}
