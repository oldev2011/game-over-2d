using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float SpeedEnemy;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    void Update()
    {
        _transform.Translate (Vector3.down * SpeedEnemy * Time.deltaTime);
    }
}
