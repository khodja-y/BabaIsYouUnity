using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelCreator)), CanEditMultipleObjects]
[ExecuteInEditMode]
public class LevelCreatorInspector : Editor
{
    ElementType currentSelected = ElementType.Empty;

    
    Dictionary<ElementType, Texture> textureHolder = new Dictionary<ElementType, Texture>();
    private void OnEnable()
    {
        textureHolder.Add(ElementType.Empty, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Objets/empty.png"));
        textureHolder.Add(ElementType.Poop, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Objets/Poop.png"));
        textureHolder.Add(ElementType.Wall, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Objets/Wall.png"));
        textureHolder.Add(ElementType.Toilet, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Objets/Toilet.png"));
        textureHolder.Add(ElementType.PQ, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Objets/PQ.png"));
        textureHolder.Add(ElementType.Water, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Objets/Water1.png"));
        textureHolder.Add(ElementType.IsWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/IsWord.png"));
        textureHolder.Add(ElementType.PoopWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/PoopWord2.png"));
        textureHolder.Add(ElementType.WallWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/WallWord.png"));
        textureHolder.Add(ElementType.PQWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/PQWord.png"));
        textureHolder.Add(ElementType.ToiletWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/ToiletWord.png"));
        textureHolder.Add(ElementType.YouWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/YouWord2.png"));
        textureHolder.Add(ElementType.PushWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/PushWord.png"));
        textureHolder.Add(ElementType.WinWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/WinWord.png"));
        textureHolder.Add(ElementType.StopWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/StopWord.png"));
        textureHolder.Add(ElementType.WaterWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/WaterWord.png"));
        textureHolder.Add(ElementType.SinkWord, (Texture)EditorGUIUtility.Load("Assets/EditorDefaultSprites/Words/SinkWord.png"));
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();


        LevelCreator levelCreator = (LevelCreator)target;
        int rows = (int)Mathf.Sqrt(levelCreator.level.Count);



        Rect vert = (Rect)EditorGUILayout.BeginVertical();

    


        for (int r = rows - 1; r >= 0; r--)
        {

            Rect Hori = EditorGUILayout.BeginHorizontal();

            for (int c = 0; c < rows; c++)
            {
                if (GUILayout.Button(textureHolder[levelCreator.level[c + ((rows) * r)]], GUILayout.Width(30), GUILayout.Height(30)))
                {
                    levelCreator.level[c + ((rows) * r)] = currentSelected;
                }
            }

            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.EndVertical();

        EditorGUILayout.Space(20);

        int count = 0;
        foreach (KeyValuePair<ElementType, Texture> e in textureHolder)
        {
            count++;
            if (GUILayout.Button(e.Value, GUILayout.Width(50), GUILayout.Height(50)))
            {
                currentSelected = e.Key;
            }
            if (count % 4 == 0)
            {
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.BeginHorizontal();
            }
        }

       
    }
















    
}
