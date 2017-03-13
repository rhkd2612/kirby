using UnityEngine;
using UnityEditor;
using UnityEngine.EventSystems;
using System.Collections;

[CustomEditor(typeof(ButtonScale))]

public class ButtonScale_Editor : Editor {

    ButtonScale _buttonscale;

    void OnEnable()
    {
        _buttonscale = target as ButtonScale;

    }
    public override void OnInspectorGUI()
    {
        _buttonscale.bt_scale = EditorGUILayout.Vector3Field("Press", _buttonscale.bt_scale, GUILayout.Height(20));
        _buttonscale.Duration = EditorGUILayout.FloatField("Duration", _buttonscale.Duration, GUILayout.Height(20));
    }
}
