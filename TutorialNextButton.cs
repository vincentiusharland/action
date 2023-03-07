using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialNextButton : MonoBehaviour
{
    [SerializeField] GameObject targetPage1;
    [SerializeField] GameObject targetPage2;
    [SerializeField] GameObject targetPage3;
    bool page1=true;
    bool page2=false;
    bool page3=false;

    public void nextPage()
    {
        if(page1)
        {
            targetPage2.gameObject.SetActive(true);
            targetPage1.gameObject.SetActive(false);
            page2 = true;
            page1 = false;
            return;
        }
        if (page2)
        {
            targetPage3.gameObject.SetActive(true);
            targetPage2.gameObject.SetActive(false);
            page3 = true;
            page2 = false;
            return;
        }
        if (page3)
        {
            targetPage1.gameObject.SetActive(true);
            targetPage3.gameObject.SetActive(false);
            page1 = true;
            page3 = false;
        }
    }
}
