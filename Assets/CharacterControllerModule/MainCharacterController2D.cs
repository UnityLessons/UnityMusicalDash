using UnityEngine;
using System.Collections;

[AddComponentMenu("Modular Character Controls/Main Character Controller 2D")]
public class MainCharacterController2D : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        foreach (CharacterController2DModule module in GetComponents<CharacterController2DModule>())
        {
            if (module.enabled)
            {
                module.Init();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (CharacterController2DModule module in GetComponents<CharacterController2DModule>())
        {
            if (module.enabled)
            {
                module.Control(); 
            }
        }
    }
}
