using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _Enemy;
    [SerializeField] private Transform _EnemySpawnPlace;
    
    private void Spawn()
    {
        Instantiate(_Enemy, _EnemySpawnPlace.position, _EnemySpawnPlace.rotation);
    }
    void Start()
    {
        Invoke("Spawn", 3);
        
    }


    void Update()
    {
        
    }


}
 