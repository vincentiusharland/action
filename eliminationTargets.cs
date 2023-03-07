using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminationTargets : MonoBehaviour
{
    [SerializeField] GameObject target1;
    [SerializeField] GameObject target2;
    [SerializeField] GameObject target3;
    [SerializeField] GameObject target4;
    [SerializeField] GameObject target5;
    [SerializeField] GameObject target6;
    [SerializeField] GameObject boss;
    [SerializeField] GameObject warpManager;
    int i = 1;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(target1.activeInHierarchy==false&&target2.activeInHierarchy == false && target3.activeInHierarchy == false && target4.activeInHierarchy == false && target5.activeInHierarchy == false && target6.activeInHierarchy == false&&i>0)
        {
            boss.SetActive(true);
            warpManager.SetActive(true);
            i--;
        }

    }
}
