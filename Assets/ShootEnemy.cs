using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public GameObject nearestEnemy;
    public GameObject[] Enemies;
    // Start is called before the first frame update
    void Awake()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (var enemy in Enemies)
        {

        }
    }
}
