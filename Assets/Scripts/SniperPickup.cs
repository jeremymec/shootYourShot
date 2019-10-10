using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperPickup : MonoBehaviour
{
    public Sprite playerGun;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;

        player.GetComponent<SniperShoot>().hasGun = true;
        player.GetComponent<SpriteRenderer>().sprite = playerGun;

        Destroy(this.gameObject);
    }
}
