using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 0;
    [SerializeField] private int health = 100;
    [SerializeField] private GameObject deathVFX, DeathVFXPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void DecreaseHealth(int decrease)
    {
        health -= decrease;
        if (health <= 0)
        {
            Destroy(gameObject);
            TriggerVFX();
        } 
    }

    private void TriggerVFX()
    {
        if (!deathVFX) { return; };
        GameObject deathOBJ = Instantiate(deathVFX, DeathVFXPos.transform.position, transform.rotation);
        Destroy(deathOBJ, 1f);
    }
}