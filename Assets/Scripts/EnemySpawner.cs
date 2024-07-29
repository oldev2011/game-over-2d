using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float BorderPositionX;
    public float BorderPositionY;

    private float RandomSpawnX;
    private bool _canSpawn = true;
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        InvokeRepeating("SpawnEnemy",1f,5f);
    }
    private void Update()
    {
        
    }
    private void SpawnEnemy()
    {
        RandomSpawnX = Random.Range(-BorderPositionX, BorderPositionX);
        Instantiate(EnemyPrefab, new Vector3(RandomSpawnX,BorderPositionY, _transform.position.z),Quaternion.identity);
    }
}
