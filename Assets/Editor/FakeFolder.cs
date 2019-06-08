using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using UnityEngine;
using UnityEditor;


[InitializeOnLoad]
public class FakeFolder {

    public static readonly Color32 BG_COLOR_FREE = new Color32(194, 194, 194, 255);

    static FakeFolder() {
        EditorApplication.projectWindowItemOnGUI += ReplaceFolderIcon;
    }

    private static void ReplaceFolderIcon(string guid, Rect rect) {
        string path = AssetDatabase.GUIDToAssetPath(guid);
        if (!AssetDatabase.IsValidFolder(path)) {
            return;
        }
        Texture bg = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Images/bg.png"); ;
        Texture texture = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Images/ICON.png"); ;

        rect.width = rect.height;

        GUI.DrawTexture(rect, bg);
        GUI.DrawTexture(rect, texture);

        EditorApplication.RepaintProjectWindow();
    }
}
