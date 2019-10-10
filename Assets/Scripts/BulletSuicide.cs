﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSuicide : MonoBehaviour
{

    public float bulletTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
