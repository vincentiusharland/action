using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class shopRandomizer : MonoBehaviour
{
    public static shopRandomizer instance;
    [SerializeField] Image shopItem;
    [SerializeField] GameObject shopObject1;
    [SerializeField] GameObject shopObject2;
    [SerializeField] GameObject shopObject3;
    [SerializeField] GameObject shopObject4;
    [SerializeField] GameObject shopObject5;
    [SerializeField] GameObject shopObject6;
    [SerializeField] GameObject specialCase;
    [SerializeField] Image description;
    [SerializeField] Text descriptionTitle;
    [SerializeField] Text descriptionText;
    public Text Notification;
    int randomBank;

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if(shopItem.sprite==null)
        {
            randomizeShop();
            
        }
        HP.instance.avail_health = HP.instance.max_health;
        MovePerfect.instance.available_skill = MovePerfect.instance.skill_cap;
    }
    public void randomizeShop()
    {
        int randomNum = Random.Range(1, 6 + 1);
        randomBank = randomNum;
        if(randomNum==1)
        {
            shopItem.sprite = shopObject1.GetComponent<SpriteRenderer>().sprite;
            shopItem.gameObject.SetActive(true);
        }
        if (randomNum == 2)
        {
            shopItem.sprite = shopObject2.GetComponent<SpriteRenderer>().sprite;
            shopItem.gameObject.SetActive(true);
        }
        if (randomNum == 3)
        {
            shopItem.sprite = shopObject3.GetComponent<SpriteRenderer>().sprite;
            shopItem.gameObject.SetActive(true);
        }
        if (randomNum == 4)
        {
            shopItem.sprite = shopObject4.GetComponent<SpriteRenderer>().sprite;
            shopItem.gameObject.SetActive(true);
        }
        if (randomNum == 5)
        {
            shopItem.sprite = shopObject5.GetComponent<SpriteRenderer>().sprite;
            shopItem.gameObject.SetActive(true);
        }
        if (randomNum == 6)
        {
            shopItem.sprite = shopObject6.GetComponent<SpriteRenderer>().sprite;
            shopItem.gameObject.SetActive(true);
        }
    }
    public void ShowDescription()
    {
       
        //description.gameObject.SetActive(true);
        //descriptionText.gameObject.SetActive(true);
        if (randomBank == 1)
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = shopObject1.GetComponent<SpriteRenderer>().sprite;
            descriptionTitle.text = "Claw Attack";
            descriptionText.text = "Short range, Power 5";
        }
        if (randomBank == 2)
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = shopObject2.GetComponent<SpriteRenderer>().sprite;
            descriptionTitle.text = "Experience Orb";
            descriptionText.text = "Experience+1";
        }
        if (randomBank == 3)
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = shopObject3.GetComponent<SpriteRenderer>().sprite;
            descriptionTitle.text = "FireBall";
            descriptionText.text = "Long range, Power 5";
        }
        if (randomBank == 4)
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = shopObject4.GetComponent<SpriteRenderer>().sprite;
            descriptionTitle.text = "Lightning Bolt";
            descriptionText.text = "straight line, Power 5";
        }
        if (randomBank == 5)
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = shopObject5.GetComponent<SpriteRenderer>().sprite;
            descriptionTitle.text = "Plant Shooter";
            descriptionText.text = "Long range, Power 3";
        }
        if (randomBank == 6)
        {
            description.gameObject.SetActive(true);
            descriptionText.gameObject.SetActive(true);
            descriptionTitle.gameObject.SetActive(true);
            description.sprite = shopObject6.GetComponent<SpriteRenderer>().sprite;
            descriptionTitle.text = "Wind Slash";
            descriptionText.text = "Medium range, Power 10";
        }

    }
    public void HideDescription()
    {
        description.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(false);
        descriptionTitle.gameObject.SetActive(false);
    }
    public void Buy()
    {
        GameObject BasicAttack = MovePerfect.instance.attack_projectile;
        GameObject Skill = MovePerfect.instance.skill_projectile;
        GameObject manager = GameObject.FindGameObjectWithTag("GameObjectManager");
        if(CoinsManager.instance.currentCoins<3)
        {
            Notification.gameObject.SetActive(true);
            Notification.text = "Insufucient Gold, Please Come Again Later!";
            return;
        }
        if (randomBank == 1)
        {
           if(BasicAttack.name=="ClawAttack")
            {
                HP.instance.dmgBasicAttack++;
                Notification.gameObject.SetActive(true);
                CoinsManager.instance.currentCoins -= 3;
                Notification.text = "Thankyou for buying, your ClawAttack power +1";
                shopItem.gameObject.SetActive(false);
                return;
            }
            manager.GetComponent<GameObjectSaver>().BasicAttack = shopObject1;
            HP.instance.dmgBasicAttack = 5;
            Notification.gameObject.SetActive(true);
            CoinsManager.instance.currentCoins -= 3;
            Notification.text = "Thankyou for buying, you Learned ClawAttack!";
            shopItem.gameObject.SetActive(false);
        }
        if (randomBank == 2)
        {
            LevelManager.instance.currentExperience++;
            Notification.gameObject.SetActive(true);
            CoinsManager.instance.currentCoins -= 3;
            Notification.text = "Thankyou for buying, your Experience +1!";
            shopItem.gameObject.SetActive(false);
        }
        if (randomBank == 3)
        {
            if (Skill.name == "FireBall")
            {
                HP.instance.dmgSkill++;
                Notification.gameObject.SetActive(true);
                CoinsManager.instance.currentCoins -= 3;
                Notification.text = "Thankyou for buying, your FireBall power +1";
                shopItem.gameObject.SetActive(false);
                return;
            }
            manager.GetComponent<GameObjectSaver>().Skill = shopObject3;
            HP.instance.dmgSkill = 5;
            Notification.gameObject.SetActive(true);
            CoinsManager.instance.currentCoins -= 3;
            Notification.text = "Thankyou for buying, you Learned FireBall!";
            shopItem.gameObject.SetActive(false);
        }
        if (randomBank == 4)
        {
            if (Skill.name == "LightningBolt")
            {
                HP.instance.dmgSkill++;
                Notification.gameObject.SetActive(true);
                CoinsManager.instance.currentCoins -= 3;
                Notification.text = "Thankyou for buying, your LightningBolt power +1";
                shopItem.gameObject.SetActive(false);
                return;
            }
            manager.GetComponent<GameObjectSaver>().Skill = specialCase;
            HP.instance.dmgSkill = 5;
            Notification.gameObject.SetActive(true);
            CoinsManager.instance.currentCoins -= 3;
            Notification.text = "Thankyou for buying, you Learned LightningBolt!";
            shopItem.gameObject.SetActive(false);
        }
        if (randomBank == 5)
        {
            if (Skill.name == "PlantShoot")
            {
                HP.instance.dmgSkill++;
                Notification.gameObject.SetActive(true);
                CoinsManager.instance.currentCoins -= 3;
                Notification.text = "Thankyou for buying, your PLantShooter power +1";
                shopItem.gameObject.SetActive(false);
                return;
            }
            manager.GetComponent<GameObjectSaver>().Skill = shopObject5;
            HP.instance.dmgSkill = 3;
            Notification.gameObject.SetActive(true);
            CoinsManager.instance.currentCoins -= 3;
            Notification.text = "Thankyou for buying, you Learned PlantShooter!";
            shopItem.gameObject.SetActive(false);
        }
        if (randomBank == 6)
        {
            if (BasicAttack.name == "WindSlash")
            {
                HP.instance.dmgBasicAttack++;
                Notification.gameObject.SetActive(true);
                CoinsManager.instance.currentCoins -= 3;
                Notification.text = "Thankyou for buying, your WindSlash power +1";
                shopItem.gameObject.SetActive(false);
                return;
            }
            manager.GetComponent<GameObjectSaver>().BasicAttack = shopObject6;
            HP.instance.dmgBasicAttack = 10;
            Notification.gameObject.SetActive(true);
            CoinsManager.instance.currentCoins -= 3;
            Notification.text = "Thankyou for buying, you Learned WindSlash!";
            shopItem.gameObject.SetActive(false);
        }
       
    }

}
    

