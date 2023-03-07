using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] Image experience;
    public float maxExperience=2;
    public float currentExperience=0;
    public float currentLevel=1;
    [SerializeField]Text level;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        level.text = "" + currentLevel;
        experience.fillAmount = currentExperience / maxExperience;
        if(currentExperience==maxExperience)
        {
            maxExperienceUp();
            levelUp();
            
            currentExperience = 0;
        }
    }
    public void experienceUp()
    {
        currentExperience++;
    }
    public void maxExperienceUp()
    {
        maxExperience++;
    }
    public void levelUp()
    {
        currentLevel++;
        HP.instance.max_health += 10;
        HP.instance.dive_dmg++;
        MovePerfect.instance.skill_cap++;
        HP.instance.dmgBasicAttack++;
    }
}
