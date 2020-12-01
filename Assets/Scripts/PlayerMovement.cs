using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header(("Настойка скорости персонажа"))]
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float JumpH = 1500;
    void Start()
    {
        
    }
       
    void Update()
    {        
        _direction.x = Input.GetAxis("Horizontal");        
        _direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {        
        if (_direction.x > 0) Fire.dir = 1; 
        if (_direction.x < 0) Fire.dir = -1;
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
        var speed = _direction * _speed * Time.deltaTime;        
        transform.Translate(speed);
    }

    private void Jump()
    {
        //Vector3 JumpT = new Vector3(0, transform.position.y, 0);
        GetComponent<Rigidbody>().AddForce(0, JumpH, 0);
    }
}
