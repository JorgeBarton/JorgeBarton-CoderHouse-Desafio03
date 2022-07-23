using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurretFire_v01 : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    // Start is called before the first frame update
    void Start()
    {
        Fire();
        Debug.Log("fire1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        Instantiate(bullet,barrel.transform);
        Debug.Log("Fire2");
    }
}
