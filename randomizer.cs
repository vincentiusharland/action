using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    [SerializeField] GameObject targetParent;
    [SerializeField] bool kinematic;
    [SerializeField] bool dynamic;
    [SerializeField] bool boss;
    [SerializeField] bool ground;
    
    GameObject instance;
    int randomBank;

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
        if (instance==null)
        {
            pickRandomNumber();

        }
        if(instance)
        {
            Vector3 currentPosition = instance.transform.position;
            Vector3 targetPosition = targetParent.transform.position;
            Vector3 targetY = new Vector3(0, targetPosition.y, 0);
            Vector3 currentY = new Vector3(0, currentPosition.y, 0);
            if (Vector3.Distance(currentY, targetY) > 10f)
            {
                instance.SetActive(false);
            }
        }

        if (instance.activeSelf == false)
        {
            targetParent.SetActive(false);
        }
    }
    public void pickRandomNumber()
    {
        
        if(boss)
        {
            int randomNum = Random.Range(1, 2 + 1);
            randomBank = randomNum;
            switch (randomBank)
            {
                case 1:
                    instance = Instantiate(Resources.Load("OldWitch", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 2:
                    instance = Instantiate(Resources.Load("Rockslide", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;

            }
        }
        if(dynamic)
        {
            int randomNum = Random.Range(1, 2 + 1);
            randomBank = randomNum;
            switch (randomBank)
            {
                case 1:
                    instance = Instantiate(Resources.Load("Rat", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 2:
                    instance = Instantiate(Resources.Load("Dino", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;

            }
        }
        if(ground)
        {
            int randomNum = Random.Range(1, 3 + 1);
            randomBank = randomNum;
            switch (randomBank)
            {
                case 1:
                    instance = Instantiate(Resources.Load("Plant", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 2:
                    instance = Instantiate(Resources.Load("Slug", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 3:
                    instance = Instantiate(Resources.Load("Worm", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
            }
        }
        if(kinematic)
        {
            int randomNum = Random.Range(1, 6 + 1);
            randomBank = randomNum;
            switch (randomBank)
            {
                case 1:
                    instance = Instantiate(Resources.Load("Eagle", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 2:
                    instance = Instantiate(Resources.Load("Dragon", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 3:
                    instance = Instantiate(Resources.Load("Fly", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 4:
                    instance = Instantiate(Resources.Load("Gnome", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 5:
                    instance = Instantiate(Resources.Load("Greeny", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
                case 6:
                    instance = Instantiate(Resources.Load("Swamp", typeof(GameObject))) as GameObject;
                    instance.transform.position = targetParent.transform.position;
                    break;
            }
        }
       
        }


    }
    

