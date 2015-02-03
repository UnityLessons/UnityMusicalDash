using UnityEngine;
using System.Collections;

public class CharacterController2D : MonoBehaviour
{
    public float movementSpeed = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKey)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            //transform.Translate(Vector3.right * horizontal * movementSpeed * Time.deltaTime);
            Vector2 currentVelocity = rigidbody2D.velocity;
            currentVelocity.x = horizontal * movementSpeed;
            rigidbody2D.velocity = currentVelocity; 
        }

        Animator animator = GetComponent<Animator>();
        animator.SetFloat("CharacterVelocityX", rigidbody2D.velocity.x);
    }
}
