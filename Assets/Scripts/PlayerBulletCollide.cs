using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletCollide : MonoBehaviour
{

    public GameObject bloodstain;
    private bool isPlayer2;

    // Start is called before the first frame update
    void Start()
    {
        isPlayer2 = gameObject.GetComponent<CharacterMovement>().isPlayer2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPlayer2)
        {
            if (collision.CompareTag("Player1Bullet"))
            {
                Instantiate(bloodstain, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);

            }
        } else
        {
            if (collision.CompareTag("Player2Bullet"))
            {
                Instantiate(bloodstain, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);
            }
        }

    }
}
