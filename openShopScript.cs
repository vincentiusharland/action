using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openShopScript : MonoBehaviour
{
    [SerializeField] GameObject targetShop;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                targetShop.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            shopRandomizer.instance.Notification.gameObject.SetActive(false);
            targetShop.SetActive(false);
        }
    }
}
