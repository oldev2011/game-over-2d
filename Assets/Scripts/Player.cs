using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public float BorderPositionX;
    public GameObject BulletPrefab;
    public TMP_Text EndText;

    private Transform _transform;
    private bool _isShooting = true;
    private float _bulletShootOffset = 1f;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) && _transform.position.x >= -BorderPositionX) 
        {
            _transform.Translate(Vector3.left * PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && _transform.position.x <= BorderPositionX) 
        {
            _transform.Translate(Vector3.right * PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space )) 
        {
            SpawnBullet();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameManeger.Instance.LivesSlider--;
            Destroy(collision.gameObject);
        }
        if(GameManeger.Instance.LivesSlider == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        EndText.text = "Вы проиграли, нажмите [R], чтобы начать заново.";
    }
    public void SpawnBullet() 
    {
        Instantiate(BulletPrefab,new Vector3 (_transform.position.x, _transform.position.y + _bulletShootOffset, _transform.position.z), Quaternion.identity);
    }

}
