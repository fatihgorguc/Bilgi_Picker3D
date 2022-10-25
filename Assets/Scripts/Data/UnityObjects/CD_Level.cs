using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Picter3D/CD_Level")]

public class CD_Level : ScriptableObject
{
     public List<LevelData> Levels = new List<LevelData>();
}
