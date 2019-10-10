using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLogic : MonoBehaviour
{

    public float weaponSpawnTime;
    public bool weaponSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weaponSpawnTime -= Time.deltaTime;

        if (weaponSpawnTime <= 0.0f && weaponSpawn)
        {
            weaponSpawn = false;
            this.spawnWeapons();
        }
    }

    void spawnWeapons()
    {

    }
}
