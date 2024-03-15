using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health, maxHealth = 10f;

	public GameObject deathEffect;

	public HealthBar healthBar;

	void Start()
    {
        health = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

	public void TakeDamage(float damageAmount)
	{
		health -= damageAmount;

		healthBar.SetHealth(health);

		if (health <= 0)
		{
			GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
			Destroy(effect, 0.5f);
			LevelManager.manager.GameOver();
			Destroy(GameObject.Find("HealthBar"));
			Destroy(gameObject);
		}
	}
}
