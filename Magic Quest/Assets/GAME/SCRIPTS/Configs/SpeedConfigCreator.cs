
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class SpeedConfigCreator
{
    [MenuItem("Tools/Create Default SpeedConfigCreator")] // Create a menu item in Unity Editor
    public static void CreateSpeedConfig()
    {
        var config = ScriptableObject.CreateInstance<SpeedConfig>(); // Create an instance of SpeedConfig
        
        AssetDatabase.CreateAsset(config, "Assets/NewSpeedConfig.asset"); // Save the asset in the Assets folder
        AssetDatabase.SaveAssets(); // Save the changes to the asset database
        Selection.activeObject = config; // Select the newly created asset in the editor
        
        Debug.Log("SpeedConfig создан в Assets/");
    }
}
#endif