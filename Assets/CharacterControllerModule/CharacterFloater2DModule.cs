using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SimpleJumpControl2DModule))]
[AddComponentMenu("Modular Character Controls/Character Floater 2D Module")]
public class CharacterFloater2DModule : CharacterController2DModule
{
    public float fallingRatio = 0.0f;
    public float floatTime = 3.0f;
    private float floatTimer = 0.0f;
    private float gravityScale = 1.0f;

    public bool isGrounded
    {
        get
        {
            return GetComponent<SimpleJumpControl2DModule>().isGrounded;
        }
    }

    public bool isFloatUsed = false;
    public bool canIFloat
    {
        get
        {
            return !isFloatUsed && !isGrounded && amIFalling && !isDoubleJumpUsed;
        }
    }

    private DoubleJumpControl2DModule _doubleJump;
    private DoubleJumpControl2DModule doubleJump
    {
        get
        {
            if (_doubleJump == null)
            {
                _doubleJump = GetComponent<DoubleJumpControl2DModule>();
            }
            return _doubleJump;
        }
    }

    private bool isDoubleJumpUsed
    {
        get
        {
            if (doubleJump == null)
            {
                return false;
            }
            else
            {
                return doubleJump.isDoubleJumpUsed;
            }
        }
    }

    public bool doIWantToFloat
    {
        get
        {
            return Input.GetButton("Jump");
        }
    }

    public bool amIFalling
    {
        get
        {
            return rigidbody2D.velocity.y < 0.0f;
        }
    }

    public bool amIFloating = false;

    public override void Init()
    {
        Debug.Log("CharacterFloater2DModule Initialized!!");
        gravityScale = rigidbody2D.gravityScale;
    }

    public override void Control()
    {
        FloatResetControl();
        FloatControl();
    }

    private void FloatControl()
    {
        if (canIFloat && doIWantToFloat)
        {
            Float();
        }

        if (amIFloating)
        {
            FloatLimitControl();
        }
    }

    private void Float()
    {
        Vector2 currentVelocity = rigidbody2D.velocity;
        currentVelocity.y *= fallingRatio;

        rigidbody2D.gravityScale = 0.0f;
        rigidbody2D.velocity = currentVelocity;
        amIFloating = true;
    }

    private void FloatLimitControl()
    {
        floatTimer += Time.deltaTime;
        if (floatTimer >= floatTime || !doIWantToFloat)
        {
            isFloatUsed = true;
            amIFloating = false;
            rigidbody2D.gravityScale = gravityScale;
        }
    }

    private void FloatResetControl()
    {
        if (isGrounded)
        {
            isFloatUsed = false;
            floatTimer = 0.0f;
        }
    }
}
