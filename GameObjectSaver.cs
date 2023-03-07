using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectSaver : MonoBehaviour
{
    public static GameObjectSaver instance;
    public GameObject BasicAttack;
    public GameObject Skill;
  


    private void Awake()
    {
        instance = this;
        GameObject[] Manager = GameObject.FindGameObjectsWithTag("GameObjectManager");
        if (Manager.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
 
    void Update()
    {
        ChangeBasicAttack();
        ChangeSkill();
        
    }
   
    public void ChangeBasicAttack()
    {
        MovePerfect.instance.attack_projectile = BasicAttack;
    }
    public void ChangeSkill()
    {
        MovePerfect.instance.skill_projectile = Skill;
    }
}
