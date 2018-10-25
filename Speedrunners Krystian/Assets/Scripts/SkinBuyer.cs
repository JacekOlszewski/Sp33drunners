using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinBuyer : MonoBehaviour
{
    private int SkinPrice = 165;
    private Text creditsAmountLabel;
    // Use this for initialization
    void Start () {
	    if (!PlayerPrefs.HasKey("IceSkin"))
	    {
	        PlayerPrefs.SetInt("IceSkin", 0); //0 doesnt have 1 has
	    }
	    if (!PlayerPrefs.HasKey("FireSkin"))
	    {
	        PlayerPrefs.SetInt("FireSkin", 0); //0 doesnt have 1 has
	    }
	    if (!PlayerPrefs.HasKey("GrasslandsSkin"))
	    {
	        PlayerPrefs.SetInt("GrasslandsSkin", 0); //0 doesnt have 1 has
	    }
	    if (!PlayerPrefs.HasKey("AquaSkin"))
	    {
	        PlayerPrefs.SetInt("AquaSkin", 0); //0 doesnt have 1 has
	    }

	    if (PlayerPrefs.GetInt("IceSkin") == 1)
	    {
	        GameObject.Find("IceSkinButton").GetComponentInChildren<Text>().text = "Bought";
            GameObject.Find("IceSkinButton").GetComponent<Button>().interactable  = false;

        }
        if (PlayerPrefs.GetInt("FireSkin") == 1)
	    {
            GameObject.Find("FireSkinButton").GetComponentInChildren<Text>().text = "Bought";
            GameObject.Find("FireSkinButton").GetComponent<Button>().interactable  = false;
        }
        if (PlayerPrefs.GetInt("GrasslandsSkin") == 1)
	    {
            GameObject.Find("GrasslandsSkinButton").GetComponentInChildren<Text>().text = "Bought";
            GameObject.Find("GrasslandsSkinButton").GetComponent<Button>().interactable  = false;
        }
        if (PlayerPrefs.GetInt("AquaSkin") == 1)
	    {
            GameObject.Find("AquaSkinButton").GetComponentInChildren<Text>().text = "Bought";
            GameObject.Find("AquaSkinButton").GetComponent<Button>().interactable  = false;
        }

        creditsAmountLabel = GameObject.Find("CreditsAmountText").GetComponent<Text>();


    }
	
	// Update is called once per frame
	void Update () {
	    
    }

    public void getFireSkin()
    {
        int creditsAmount = PlayerPrefs.GetInt("Credits");
        if (creditsAmount >= SkinPrice)
        {
            GameObject.Find("FireSkinButton").GetComponentInChildren<Text>().text = "Bought";
            GameObject.Find("FireSkinButton").GetComponent<Button>().interactable  = false;
            creditsAmount -= SkinPrice;
            PlayerPrefs.SetInt("Credits", creditsAmount);
            PlayerPrefs.SetInt("FireSkin", 1);
            creditsAmountLabel.text = creditsAmount.ToString();
        }
    }

    public void getIceSkin()
    {
        int creditsAmount = PlayerPrefs.GetInt("Credits");
        if (creditsAmount >= SkinPrice)
        {
            GameObject.Find("IceSkinButton").GetComponentInChildren<Text>().text = "Bought";
             GameObject.Find("IceSkinButton").GetComponent<Button>().interactable  = false;
            creditsAmount -= SkinPrice;
            PlayerPrefs.SetInt("Credits", creditsAmount);
            PlayerPrefs.SetInt("IceSkin", 1);
            creditsAmountLabel.text = creditsAmount.ToString();
        }
    }

    public void getGrasslandsSkin()
    {
        int creditsAmount = PlayerPrefs.GetInt("Credits");
        if (creditsAmount >= SkinPrice)
        {
            GameObject.Find("GrasslandsSkinButton").GetComponentInChildren<Text>().text = "Bought";
            GameObject.Find("GrasslandsSkinButton").GetComponent<Button>().interactable  = false;
            creditsAmount -= SkinPrice;
            PlayerPrefs.SetInt("Credits", creditsAmount);
            PlayerPrefs.SetInt("GrasslandsSkin", 1);
            creditsAmountLabel.text = creditsAmount.ToString();
        }
    }

    public void getAquaSkin()
    {
        int creditsAmount = PlayerPrefs.GetInt("Credits");
        if (creditsAmount >= SkinPrice)
        {
            GameObject.Find("AquaSkinButton").GetComponentInChildren<Text>().text = "Bought";
            GameObject.Find("AquaSkinButton").GetComponent<Button>().interactable  = false;
            creditsAmount -= SkinPrice;
            PlayerPrefs.SetInt("Credits", creditsAmount);
            PlayerPrefs.SetInt("AquaSkin", 1);
            creditsAmountLabel.text = creditsAmount.ToString();
        }
    }
}
