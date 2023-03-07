using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDamager : MonoBehaviour
{
    [SerializeField] float power = 5;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        #region COLLISION DMG
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<HP>().lose_health(power);

        }
        #endregion
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        #region COLLISION DMG
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<HP>().lose_health(power);

        }
        #endregion
    }
}
