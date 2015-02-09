using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SimpleJumpControl2DModule))]
[AddComponentMenu("Modular Character Controls/Character Floater 2D Module")]
public class CharacterFloater2DModule : CharacterController2DModule
{
    public bool isGrounded
    {
        get
        {
            return GetComponent<SimpleJumpControl2DModule>().isGrounded;
        }
    }

    private bool isFloatUsed = false;
    public bool canIFloat
    {
        get
        {
            return !isFloatUsed && !isGrounded;
        }
    }

    public bool doIWantToFloat
    {
        get
        {
            return Input.GetButton("Jump");
        }
    }

    public override void Init()
    {
        Debug.Log("CharacterFloater2DModule Initialized!!");
    }

    public override void Control()
    {

    }

    private void FloatControl()
    {
        if (canIFloat && doIWantToFloat)
        {
            Float();
        }
    }

    private void Float()
    {

    }

    private void FloatResetControl()
    {

    }
}
