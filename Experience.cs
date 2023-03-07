using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("experiencegain");
            LevelManager.instance.experienceUp();
            LevelManager.instance.experienceUp();
            CoinsManager.instance.CoinsUp();
            HP.instance.avail_health += 5;
            MovePerfect.instance.available_skill += 5;
            Destroy(gameObject);
        }

    }
   
}
