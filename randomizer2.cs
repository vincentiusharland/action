using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer2 : MonoBehaviour
{
    [SerializeField] GameObject targetParent;
    
    int randomBank;
    GameObject instance;
    
    private void Awake()
    {
        

    }
    // Start is called before the first frame update
    void Start()
    {
        //pickRandomNumber(10);

    }

    // Update is called once per frame
    void Update()
    {
        print(randomBank);
        if (instance==null)
        {
           
            pickRandomNumber(6);
            
        }
        if (instance.activeSelf == false)
        {
            targetParent.SetActive(false);
        }
    }
    public void pickRandomNumber(int maxInt)
    {
        int randomNum = Random.Range(1, maxInt + 1);
        print(randomNum);
        randomBank = randomNum;
        switch(randomBank)
        {
            case 1:
                instance = Instantiate(Resources.Load("Rat", typeof(GameObject))) as GameObject;
                instance.transform.position = targetParent.transform.position;
                break;
            case 2:
                instance = Instantiate(Resources.Load("Eagle", typeof(GameObject))) as GameObject;
                instance.transform.position = targetParent.transform.position;
                break;
            case 3:
                instance = Instantiate(Resources.Load("Plant", typeof(GameObject))) as GameObject;
                instance.transform.position = targetParent.transform.position;
                break;
            case 4:
                instance = Instantiate(Resources.Load("Gnome", typeof(GameObject))) as GameObject;
                instance.transform.position = targetParent.transform.position;
                break;
            case 5:
                instance = Instantiate(Resources.Load("Slug", typeof(GameObject))) as GameObject;
                instance.transform.position = targetParent.transform.position;
                break;
            case 6:
                instance = Instantiate(Resources.Load("Swamp", typeof(GameObject))) as GameObject;
                instance.transform.position = targetParent.transform.position;
                break;
        }
            
        }
       
        

    }
    

