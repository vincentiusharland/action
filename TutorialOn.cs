using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialOn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject targetTutorial;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (targetTutorial.activeInHierarchy == false)
            {
                targetTutorial.gameObject.SetActive(true);
                //MovePerfect.instance.canMove = false;
            }
            else
            {
                targetTutorial.gameObject.SetActive(false);
                //MovePerfect.instance.canMove = true;
            }

        }
    }
}
