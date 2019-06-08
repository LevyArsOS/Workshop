using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Teste), true), CanEditMultipleObjects]
public class TesteEditor : Editor {

    private bool enableGroup = true;

    public override void OnInspectorGUI() {
        Teste myTeste = (Teste) this.target;

        this.enableGroup = EditorGUILayout.BeginToggleGroup("ints", this.enableGroup);
        myTeste.b = EditorGUILayout.Slider(myTeste.b, 0f, 10f);
        EditorGUILayout.EndToggleGroup();

    }
}
