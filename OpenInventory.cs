using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    [SerializeField] GameObject targetInventory;
    bool inventoryOpen;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (targetInventory.activeInHierarchy == false)
            {
                targetInventory.gameObject.SetActive(true);
                //MovePerfect.instance.canMove = false;
            }
            else
            {
                targetInventory.gameObject.SetActive(false);
                //MovePerfect.instance.canMove = true;
            }

        }
    }
}
