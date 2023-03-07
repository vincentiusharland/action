using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopReset : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public Image Item1;
    public Image Item2;
    public Image Item3;
    public Image Item4;
    public Text Description;

    public void resetShop()
    {
        if(CoinsManager.instance.currentCoins<1)
        {
            Description.gameObject.SetActive(true);
            Description.text = "Insufficient Gold, come again later!";
            return;
        }
        target1.gameObject.SetActive(true);
        Item1.sprite = null;
        target2.gameObject.SetActive(true);
        Item2.sprite = null;
        target3.gameObject.SetActive(true);
        Item3.sprite = null;
        target4.gameObject.SetActive(true);
        Item4.sprite = null;
        CoinsManager.instance.currentCoins--;
    }
    public void ShowDescription()
    {
        Description.gameObject.SetActive(true);
        Description.text = "You can Reset the shop for 1 gold, good luck!";
    }
    public void HideDescription()
    {
        Description.gameObject.SetActive(false);
    }
}
