using UnityEngine;
using System.Collections;
using UnityEditor;
public class Menu1 : EditorWindow {

    [MenuItem("Amsigo/CreateBasicFolder")]
    static public void ShowWindow()
    {
        // 윈도우 생성
        Menu1 window = (Menu1)EditorWindow.GetWindow(typeof(Menu1));
        window.title = "BasicFolder Maker";
    }

    string SceneName;

    void OnGUI()
    {
        SceneName = EditorGUI.TextField(new Rect(10, 30, 300, 17), "SceneName", SceneName);

        if (GUI.Button(new Rect(180, 120, 100, 50), "Create"))
        {
            string  guid1 = AssetDatabase.CreateFolder("Assets/Resources", SceneName);
            string newFolderPath = AssetDatabase.GUIDToAssetPath(guid1);
            //생성할 폴더 목록
            string[] Folders_name = {
                      "1_Character_Sprite",
                      "2_UI_Sprite",
                      "3_Prefab",
                      "4_Script",
                      "5_Animation",
                      "6_Font",
                      "7_Sound"
                  };
            foreach (string F_name in Folders_name)
            {
                string guid2 = AssetDatabase.CreateFolder("Assets/Resources/"+SceneName, F_name);
                string newFolderPath2 = AssetDatabase.GUIDToAssetPath(guid2);
            }
        }
    }
}
