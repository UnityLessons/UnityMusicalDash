using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(FollowObject))]
public class FollowObjectEditor : Editor
{

    #region Properties

    private FollowObject _fo;
    private FollowObject fo
    {
        get
        {
            if (_fo == null)
            {
                _fo = target as FollowObject;
            }
            return _fo;
        }
    }

    private bool IsSmoothFollowing
    {
        get
        {
            return fo.isLerping;
        }
    }

    #endregion

    public override void OnInspectorGUI()
    {
        CommonInterface();

        if (IsSmoothFollowing)
        {
            SmoothInterface();
        }
        else
        {
            HardInterface();
        }
    }

    private void CommonInterface()
    {
        EditorGUILayout.ObjectField("Script", MonoScript.FromMonoBehaviour((FollowObject)target), typeof(MonoScript));
        EditorGUILayout.ObjectField("Editor Script", MonoScript.FromScriptableObject((FollowObjectEditor)this), typeof(MonoScript));
        fo.isLerping = EditorGUILayout.Toggle("Smooth Follow?", fo.isLerping);
        fo.target = EditorGUILayout.ObjectField("Target Transform", fo.target, typeof(Transform)) as Transform;
        fo.offset = EditorGUILayout.Vector3Field("Offset from target", fo.offset);
    }

    private void SmoothInterface()
    {
        //EditorGUILayout.Separator();
        fo.lerpSpeed = EditorGUILayout.FloatField("Follow Speed", fo.lerpSpeed);
    }

    private void HardInterface()
    {
        //EditorGUILayout.Separator();
    }
}


