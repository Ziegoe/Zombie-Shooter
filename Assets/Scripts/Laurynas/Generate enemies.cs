using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generateenemies : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while(enemyCount < 50)
        {
            xPos = Random.Range(10, 19);
            zPos = Random.Range(-20, 20);
            Instantiate(enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount++;
        }
    }
}
