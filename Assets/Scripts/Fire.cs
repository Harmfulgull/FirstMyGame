 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject Patron;
    [SerializeField] private GameObject _mine;
    [Header("Настойка скорости патрона")]
    [SerializeField] private float SpeedPatron = 200f;
    [SerializeField] private int _damage;
    public static float dir = 1;

    private void FireBoll()
    {
        GameObject Pat =Instantiate(Patron, gameObject.transform.position, gameObject.transform.rotation);
        Vector3 k = new Vector3(Pat.transform.position.x, Pat.transform.position.y);
        Pat.GetComponent<Rigidbody>().AddForce(k * SpeedPatron * dir);
        Destroy(Pat, 5);
    }
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            FireBoll();
        }
        if (Input.GetMouseButtonUp(1))
        {
            Instantiate(_mine, gameObject.transform.position, gameObject.transform.rotation);
        }
    }


}
