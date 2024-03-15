using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health, maxHealth = 3f;

	public GameObject deathEffect;

	void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
			GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            LevelManager.manager.IncreaseScore(10);
			Destroy(effect, 0.5f);
			Destroy(gameObject);
        }
    }
}
