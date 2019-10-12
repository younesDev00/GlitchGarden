using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] int damageAmount = 100;
    CircleCollider2D bCollider;

    void Start()
    {
        bCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (transform.position.x >= 11)
        {
            bCollider.enabled = false;
            Destroy(gameObject, 1f);
        }
        Debug.Log(transform.position);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().DecreaseHealth(damageAmount);
            Destroy(gameObject);
        }
    }
}
