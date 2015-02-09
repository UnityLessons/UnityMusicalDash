using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SimpleJumpControl2DModule))]
[AddComponentMenu("Modular Character Controls/Double Jump Control 2D")]
public class DoubleJumpControl2DModule : CharacterController2DModule
{

    private SimpleJumpControl2DModule _jumpModule;
    private SimpleJumpControl2DModule jumpModule
    {
        get
        {
            return (_jumpModule != null) ? _jumpModule : _jumpModule = GetComponent<SimpleJumpControl2DModule>();
        }
    }

    private bool isGrounded
    {
        get
        {
            return jumpModule.isGrounded;
        }
    }

    private CharacterFloater2DModule _floater;
    private CharacterFloater2DModule floater
    {
        get
        {
            if (_floater == null)
            {
                _floater = GetComponent<CharacterFloater2DModule>();
            }
            return _floater;
        }
    }

    private bool didIFloat
    {
        get
        {
            if (floater == null)
            {
                return false;
            }
            else
            {
                return floater.amIFloating || floater.isFloatUsed;
            }
        }
    }

    private bool doIWantToJump
    {
        get
        {
            return Input.GetButtonDown("Jump");
        }
    }

    private bool canIDoubleJump
    {
        get
        {
            return !isGrounded && !isDoubleJumpUsed;
        }
    }

    public bool isDoubleJumpUsed = false;
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
        Debug.Log("DoubleJumpControl initialized!");
    }

    public override void Control()
    {
        DoubleJumpControl();

        DoubleJumpResetControl();
    }

    private void DoubleJumpResetControl()
    {
        if (isGrounded)
        {
            isDoubleJumpUsed = false;
        }
    }

    private void DoubleJumpControl()
    {
        if (canIDoubleJump && doIWantToJump && !didIFloat)
        {
            UseDoubleJump();
        }
    }

    private void UseDoubleJump()
    {
        jumpModule.Jump();
        isDoubleJumpUsed = true;
    }
}
