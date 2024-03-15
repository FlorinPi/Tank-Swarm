using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public GameObject hitEffect;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth enemyComponent))
		{
			enemyComponent.TakeDamage(1);
		}

		GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
		Destroy(effect, 0.5f);
		Destroy(gameObject);
	}

}
