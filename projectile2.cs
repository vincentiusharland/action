using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile2 : MonoBehaviour
{
    [SerializeField] float projectile_speed = 8;
    [SerializeField] float dur = 0.5f;
    [SerializeField] bool enemy;
    [SerializeField] bool player;
    public float dmg;
    [SerializeField] bool hit;

    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        StartCoroutine(Duration(dur));
    }
    private void Update()
    {
        if (hit)
            return;
        projectile_movement();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (player)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                animator.SetTrigger("hit");
                StartCoroutine(Duration(0.5f));
                hit = true;
                print("col_hit");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (enemy)
                return;
            animator.SetTrigger("hit");
            StartCoroutine(Duration(0.5f));
            hit = true;
            print("col_hit");
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (enemy)
            {
                hit = true;
                FindObjectOfType<HP>().lose_health(dmg);
                animator.SetTrigger("hit");
                StartCoroutine(Duration(0.5f));
            }
            else
                return;
        }



    }

    IEnumerator Duration(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
    void projectile_movement()
    {
        transform.Translate(transform.right * transform.localScale.x * projectile_speed * Time.deltaTime);
    }
}
