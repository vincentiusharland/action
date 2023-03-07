using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryDescription : MonoBehaviour
{
    [SerializeField] Image description;
    [SerializeField] Text descriptionTitle;
    [SerializeField] Text descriptionText;
    [SerializeField] Image inventoryAttackImage;
    [SerializeField] Image inventorySkillImage;

    public void showBasicAttackDescription()
    {
        GameObject BasicAttack;
        BasicAttack = MovePerfect.instance.attack_projectile;
        if (BasicAttack.name=="ClawAttack")
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = inventoryAttackImage.sprite;
            descriptionTitle.text = "Claw Attack";
            descriptionText.text = "Short range, Power "+HP.instance.dmgBasicAttack;
        }
        if (BasicAttack.name == "WindSlash")
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = inventoryAttackImage.sprite;
            descriptionTitle.text = "Wind Slash";
            descriptionText.text = "Medium range, Power"+HP.instance.dmgBasicAttack;
        }
    }
    public void showSkillDescription()
    {
        GameObject Skill;
        Skill = MovePerfect.instance.skill_projectile;
        if (Skill.name == "FireBall")
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = inventorySkillImage.sprite;
            descriptionTitle.text = "FireBall";
            descriptionText.text = "Long range, Power "+HP.instance.dmgSkill;
        }
        if (Skill.name == "LightningBolt")
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = inventorySkillImage.sprite;
            descriptionTitle.text = "Lightning Bolt";
            descriptionText.text = "straight line, Power " + HP.instance.dmgSkill;
        }
        if (Skill.name == "PlantShoot")
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = inventorySkillImage.sprite;
            descriptionTitle.text = "Plant Shooter";
            descriptionText.text = "Long range, Power " + HP.instance.dmgSkill;
        }
    }
    public void HideDescription()
    {
        description.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(false);
        descriptionTitle.gameObject.SetActive(false);
    }
}
