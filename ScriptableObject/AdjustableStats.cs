using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "AdjustableStats", menuName = "ScriptableObjects/Dynamic Stats")]
public class AdjustableStats : ScriptableObject
{
    public int playerCritrate = 35;
    public int enemieCritrate = 15;
    public float enemiesInterval = 2.5f;
}

