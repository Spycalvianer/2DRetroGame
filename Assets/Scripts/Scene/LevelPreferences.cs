using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level Speed", menuName = "LevelPrefs")]
public class LevelPreferences : ScriptableObject
{
    public float speedFactor = 1f;
}
