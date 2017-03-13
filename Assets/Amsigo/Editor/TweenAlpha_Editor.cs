using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(TweenAlpha))]

public class TweenAlpha_Editor : Editor {
    
    TweenAlpha _tweenalpha;

	void OnEnable () {
        _tweenalpha = target as TweenAlpha;
	}

    public override void OnInspectorGUI()
    {
        #region Text
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("SetTweenAlpha");
        EditorGUILayout.LabelField("===========================================================");
        #endregion

        //Tween Slider_Setting
        #region Slider_Alpha
        EditorGUILayout.BeginHorizontal();
        _tweenalpha.Begin_Alpha = EditorGUILayout.Slider("Begin_Alpha",_tweenalpha.Begin_Alpha, 0.0f, 1.0f,GUILayout.Height(20));
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        _tweenalpha.End_Alpha = EditorGUILayout.Slider("End_Alpha", _tweenalpha.End_Alpha, 0.0f, 1.0f, GUILayout.Height(20));
        EditorGUILayout.EndHorizontal();
        #endregion

        //Tween Duration
        #region Duration
        EditorGUILayout.BeginHorizontal();
        _tweenalpha.Duration = EditorGUILayout.FloatField("Duration", _tweenalpha.Duration, GUILayout.Height(20));
        EditorGUILayout.EndHorizontal();
        #endregion
    }
}
