using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MainCharacterController2D))]
[RequireComponent(typeof(Rigidbody2D))]
[AddComponentMenu("Modular Character Controls/Simple Horizontal Movement 2D")]
public class SimpleHorizontalMovementControl2DModule : CharacterController2DModule
{

    public float movementSpeed = 10.0f;

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
        Debug.Log("SimpleHorizontalMovementModule initialized!");
    }

    public override void Control()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector2 currentVelocity = rigidbody2D.velocity;
        currentVelocity.x = horizontal * movementSpeed;
        rigidbody2D.velocity = currentVelocity;

        GetComponent<Animator>().SetFloat("CharacterVelocityX", rigidbody2D.velocity.x);
    }
}
