using UnityEngine;
using UnityEditor;

public class YourClassAsset{
    [MenuItem("Assets/Create/EnemyData")]
    public static void CreateEnemyData()
    {
        ScriptableObjectUtility.CreateAsset<EnemyData>();
    }
}
