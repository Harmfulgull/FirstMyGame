using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header(("Настойка скорости врага"))]
    [SerializeField] private float _speedEnemy;
    [Header(("Настойка границы передвижения врага"))]
    [SerializeField] private float _min;
    [SerializeField] private float _max;
    [SerializeField] private int _health;

    public void Hurt(int damage)
    {
        print("Ouch:" +damage);
        _health -= damage;
        Debug.Log("Осталось здоровья:" + _health);
        if (_health <= 0) Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position += transform.right * _speedEnemy * Time.deltaTime;
        if (transform.position.x >= _max )
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (transform.position.x <= _min)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
