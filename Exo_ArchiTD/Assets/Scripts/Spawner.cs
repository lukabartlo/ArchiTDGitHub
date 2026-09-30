using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float spawnRate;
    private List<GameObject> enemyPrefab;

    private Enemy enemy;

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(spawnRate);
    }

    private void SpawnRandomEnemyAtRandomMapLocation()
    {
        
    }
}
