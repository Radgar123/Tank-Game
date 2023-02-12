using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BoardGenerator))]
public class BoardGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        BoardGenerator board = (BoardGenerator)target;
        
        if (GUILayout.Button("Generate Board"))
        {
            board.GenerateMap();
        }
        if (GUILayout.Button("Destroy Board"))
        {
            board.ClearMap();
        }
    }
}
