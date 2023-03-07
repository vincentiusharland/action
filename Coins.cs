using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("coinGet");
            CoinsManager.instance.CoinsUp();
            CoinsManager.instance.CoinsUp();
            LevelManager.instance.experienceUp();
            HP.instance.avail_health += 5;
            MovePerfect.instance.available_skill += 5;
            Destroy(gameObject);
        }

    }
    
 
}
