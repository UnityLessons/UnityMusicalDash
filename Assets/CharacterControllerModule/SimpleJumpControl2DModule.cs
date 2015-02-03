using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MainCharacterController2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[AddComponentMenu("Modular Character Controls/Simple Jump Control 2D")]
public class SimpleJumpControl2DModule : CharacterController2DModule
{
    public bool isGrounded = false;
    public float jumpStrength = 30.0f;

    private float bottomY
    {
        get
        {
            float y = 0.0f;

            float colliderCenterY = (collider2D as BoxCollider2D).center.y;
            float colliderSizeY = (collider2D as BoxCollider2D).size.y;

            y = transform.position.y - ((colliderSizeY / 2) - colliderCenterY);

            return y;
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Init()
    {
        Debug.Log("SimpleJumpModule initialized!");
    }

    public override void Control()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Debug.Log("JUMP!!");
            Jump();
        }
    }

    public void Jump()
    {
        Vector2 currentVelocity = rigidbody2D.velocity;
        currentVelocity.y = jumpStrength;
        rigidbody2D.velocity = currentVelocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("Collision Enter With Floor!!!   " + collision.contacts[0].point + "       " + bottomY);

            float collisionPointY = collision.contacts[0].point.y;
            float bottomDistanceToCollision = collisionPointY - bottomY;

            Debug.Log("Bottom Distance = " + bottomDistanceToCollision);
            if (HelperClass.IsCloseToZero(bottomDistanceToCollision, 0.1f))
            {
                isGrounded = true;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("Collision Exit With Floor!!!");
            isGrounded = false;
        }
    }
}
