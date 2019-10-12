using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawn : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] private float minSec = 1, maxSec = 5;
    private bool spawnEnemy = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(spawnEnemy)
        {
            yield return new WaitForSeconds(Random.Range(minSec, maxSec));
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
