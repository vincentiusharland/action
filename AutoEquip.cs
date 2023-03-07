using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoEquip : MonoBehaviour
{
    public GameObject specialCase;
    public Image BasicAttack;
    public Image Skill;
    private void Update()
    {
        imageChanger();
    }
    public void imageChanger()
    {

        BasicAttack.sprite = MovePerfect.instance.attack_projectile.GetComponent<SpriteRenderer>().sprite;
        if (MovePerfect.instance.skill_projectile.name == "LightningBolt")
        {
           Skill.sprite = specialCase.GetComponent<SpriteRenderer>().sprite;
            return;
        }
        Skill.sprite = MovePerfect.instance.skill_projectile.GetComponent<SpriteRenderer>().sprite;
    }
}
