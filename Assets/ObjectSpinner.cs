using UnityEngine;
using System.Collections;

public class ObjectSpinner : MonoBehaviour 
{
	public Vector3 rotationAxis;
	public float rotationSpeed = 1.0f;
	public Space rotationSpace;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Space)) 
		{
			transform.Rotate (rotationAxis, rotationSpeed * Time.deltaTime, rotationSpace);
            
		}
	}
}
