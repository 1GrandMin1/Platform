using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    public GameObject Enemy;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
       
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
           Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }

}
