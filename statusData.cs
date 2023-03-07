using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statusData : MonoBehaviour
{
    public Text Attack;
    public Text Energy;
    public Text Health;
    public Text Dive;
    // Update is called once per frame
    void Update()
    {
        Health.text = "HP:" + "" + Player_Reference.instance.availHealth + "/" + Player_Reference.instance.maxHP;
        Energy.text = "MP:" + "" + Player_Reference.instance.skillAvail + "/" + Player_Reference.instance.skillCap;
        Dive.text = "Dive:" + "" + HP.instance.dive_dmg;
        Attack.text = "Atk: " + HP.instance.dmgBasicAttack;
    }
}
