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
        if (CanIDoubleJump() && DoIWantToJump())
        {
            UseDoubleJump();
        }
    }

    private void UseDoubleJump()
    {
        jumpModule.Jump();
        isDoubleJumpUsed = true;
    }

    private static bool DoIWantToJump()
    {
        return Input.GetButtonDown("Jump");
    }

    private bool CanIDoubleJump()
    {
        return !isGrounded && !isDoubleJumpUsed;
    }
}
