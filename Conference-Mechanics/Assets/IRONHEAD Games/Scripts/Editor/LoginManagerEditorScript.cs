using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LoginManager))]
public class LoginManagerEditorScript : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        LoginManager loginManager = (LoginManager)target;
        EditorGUILayout.HelpBox("This Script is responsbile for connecting to Photon Servers.", MessageType.Info);

        if (GUILayout.Button("Connect Anonymously"))
        {
            loginManager.ConnectAnonymously();
        }
    }
}
