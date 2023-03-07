using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    public static CoinsManager instance;
    [SerializeField] Image Coins;

    public float currentCoins = 0;
    [SerializeField]Text coins;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "" + currentCoins;
    }
    public void CoinsUp()
    {
        currentCoins++;
    }

}
