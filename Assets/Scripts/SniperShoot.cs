using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperShoot : MonoBehaviour
{

    private bool gunCoolingDown;
    private float coolDownTime = 3f;

    public Transform bullet;
    private Transform playerTransform;
    private Rigidbody2D playerRb;
    private SpriteRenderer bulletRenderer;
    private bool isPlayer2;
    public KeyCode shootKey;

    public bool hasGun;
    // Start is called before the first frame update
    void Start()
    {
        isPlayer2 = this.gameObject.GetComponent<CharacterMovement>().isPlayer2;
        gunCoolingDown = false;
        playerTransform = this.gameObject.GetComponent<Transform>();
        playerRb = this.gameObject.GetComponent<Rigidbody2D>();
        bulletRenderer = gameObject.GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(shootKey) && !gunCoolingDown && hasGun)
        {
            Vector3 position = new Vector3(playerTransform.position.x,
                playerTransform.position.y,
                0);

            Vector2 v = playerRb.velocity;
            float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Transform createdBullet = Instantiate(bullet, position, rotation);
            if (isPlayer2)
            {
                createdBullet.gameObject.tag = "Player2Bullet";
            } else
            {
                createdBullet.gameObject.tag = "Player1Bullet";
            }
            
            gunCoolingDown = true;
        }

        if (gunCoolingDown && coolDownTime <= 0f)
        {
            gunCoolingDown = false;
            coolDownTime = 3f;
        }
        else
        {
            coolDownTime -= Time.deltaTime;
        }
    }
}
