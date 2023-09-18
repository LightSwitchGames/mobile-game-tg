using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;

    private void Start()
    {
        StartCoroutine("Spawner");
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            float waitTime = Random.Range(0.2f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstaclePrefab, this.transform.position, Quaternion.identity);
        }
    }
}
