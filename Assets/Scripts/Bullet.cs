using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public GameObject DestroyEffect;
    private void Start()
    {
        Destroy(gameObject, 1f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameManeger.Instance.Points++;
            SpawnEffect(collision.transform.position);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
    }
    private void SpawnEffect(Vector2 Position) 
    {
        Instantiate(DestroyEffect,Position,Quaternion.identity);
    }
}
