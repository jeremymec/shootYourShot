using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float speed;

    public bool isPlayer2;

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal;
        float moveVertical;
        if (isPlayer2)
        {
            moveHorizontal = Input.GetAxis("HorizontalP2");
            moveVertical = Input.GetAxis("VerticalP2");
        } else
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }


        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.velocity = movement;
    }
}
