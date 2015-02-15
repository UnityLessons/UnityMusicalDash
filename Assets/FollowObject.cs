using UnityEngine;
using System.Collections;


public class FollowObject : MonoBehaviour
{
    public Transform target;
    public bool isLerping = true;

    public float lerpSpeed = 1.0f;
    public Vector3 offset = Vector3.zero;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLerping)
        {
            LerpFollow();
        }
        else
        {
            StaticFollow();
        }
    }

    void LerpFollow()
    {

    }

    void StaticFollow()
    {

    }
}
