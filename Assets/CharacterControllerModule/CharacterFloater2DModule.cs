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

    private bool _canIFloat = true;
    public bool canIFloat
    {
        get
        {
            return _canIFloat && !isGrounded;
        }
    }

    public bool doIWantToFloat
    {
        get
        {
            return Input.GetButton("Jump");
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void Init()
    {
        Debug.Log("CharacterFloater2DModule Initialized!!");
    }

    public override void Control()
    {
        
    }
}
