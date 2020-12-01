using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    
    private Vector3 CamPos = new Vector3(0f, 0.5f, -2f);
    void Start()
    {
        
    }


    void Update()
    {
            transform.position = new Vector3(Player.transform.position.x + CamPos.x,
            Player.transform.position.y + CamPos.y,
            Player.transform.position.z + CamPos.z);
    }
}
