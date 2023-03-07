using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDrop : MonoBehaviour
{
    [SerializeField] GameObject targetLocation;
    [SerializeField] GameObject targetObject;
    [SerializeField] GameObject targetObject2;
    [SerializeField] GameObject targetObject3;
    [SerializeField] GameObject targetObject4;
    [SerializeField] GameObject targetObject5;
    [SerializeField] GameObject targetObject6;
    [SerializeField] GameObject targetObject7;
    Vector3 shift = new Vector3(1, 0, 0);
    GameObject instance;
    GameObject instance2;
    int dropcap=1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (dropcap>0
            &&targetObject.activeInHierarchy == false
            && targetObject2.activeInHierarchy == false
            && targetObject3.activeInHierarchy == false
            && targetObject4.activeInHierarchy == false
            && targetObject5.activeInHierarchy == false
            && targetObject6.activeInHierarchy == false
            && targetObject7.activeInHierarchy == false
            )
        {
            DropRandomizer();
            dropcap--;
        }
    }
    public void DropRandomizer()
    {
        int randomNum = Random.Range(1, 3 + 1);
        switch (randomNum)
        {
            case 1:
                instance = Instantiate(Resources.Load("Experience", typeof(GameObject))) as GameObject;
                instance.transform.position = targetLocation.transform.position;
                instance2 = Instantiate(Resources.Load("Experience", typeof(GameObject))) as GameObject;
                instance2.transform.position = targetLocation.transform.position+shift;
                break;
            case 2:
                instance = Instantiate(Resources.Load("Experience", typeof(GameObject))) as GameObject;
                instance.transform.position = targetLocation.transform.position;
                instance2 = Instantiate(Resources.Load("Coins", typeof(GameObject))) as GameObject;
                instance2.transform.position = targetLocation.transform.position + shift;
                break;
            case 3:
                instance = Instantiate(Resources.Load("Coins", typeof(GameObject))) as GameObject;
                instance.transform.position = targetLocation.transform.position;
                instance2 = Instantiate(Resources.Load("Coins", typeof(GameObject))) as GameObject;
                instance2.transform.position = targetLocation.transform.position + shift;
                break;

        }
    }
}
