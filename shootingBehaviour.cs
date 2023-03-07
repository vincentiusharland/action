using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingBehaviour : MonoBehaviour
{
    #region RADAR
    [Header("PLAYER SEARCH")]
    [SerializeField] float check_radius = 4;
    [SerializeField] LayerMask CheckLayer;
    #endregion

    #region ATTACK
    GameObject fox;
    [Header("ATTACKING")]
    [SerializeField] GameObject attack_projectile;
    [SerializeField] Transform attack_point;
    [SerializeField] float cast_p;
    [Header("COOLDOWN")]
    [SerializeField] float nextavail;
    [SerializeField] float cooldown;
    [SerializeField] bool playerCheck = false;
    #endregion
    #region DAMAGE
    [SerializeField] float power = 5;
    #endregion
    #region AWAKE PARAMETER
    //Private parameter
    Rigidbody2D rb;
    Animator animator;
    #endregion
    private void Awake()
    {
        #region AWAKE
        fox = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        #endregion
    }
    private void Update()
    {
        player_check();
    }
    void player_check()
    {
        #region PLAYER RADAR
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, check_radius, CheckLayer);
        if (colliders.Length > 0)
        {
            playerCheck = true;
            if (Time.time > nextavail)
            {
                nextavail = Time.time + cooldown;
                StartCoroutine(Balanced_Attack(cast_p));
            }

        }
        else
            playerCheck = false;
        #endregion
    }
    IEnumerator Balanced_Attack(float cast_point)
    {
        yield return new WaitForSeconds(cast_point);
        GameObject si=Instantiate(attack_projectile, attack_point);
        si.transform.parent = null;
        SFX.PlaySFX("shoot");
    }
}
