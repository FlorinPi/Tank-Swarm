using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float interval = 3f;

	public Transform target;

	void Start()
    {
        StartCoroutine(spawnEnemy(interval, enemyPrefab));
    }

	void Update()
	{
		transform.position = new Vector3(target.position.x, target.position.y);
	}

	private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
