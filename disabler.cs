using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disabler : MonoBehaviour
{
    [SerializeField] GameObject thisObject;
    [SerializeField] GameObject thatObject;

    // Update is called once per frame
    void Update()
    {
        if(thatObject.activeInHierarchy==false)
        {
            thisObject.SetActive(false);
        }
    }
}
