using UnityEngine;
using System.Collections.Generic;

public class NewStatsImplementer : MonoBehaviour
{
    public enum AdjustOption
    {
        AdjustPlayerCritrate,
        AdjustEnemiesCritrate,
        AdjustEnemiesInterval
    }

    [Header("Scriptable Object Reference")]
    public AdjustableStats newStats;

    [Header("Target Scripts")]
    public MonsterAi monsterAI;
    public BulletStatus bulletStatus;

    [Header("Adjustment Option")]
    public AdjustOption selectedOption;

    public void ApplyAdjustment()
    {
        if (newStats == null)
        {
            Debug.LogWarning("NewStats ScriptableObject is not assigned!");
            return;
        }

        switch (selectedOption)
        {
            case AdjustOption.AdjustPlayerCritrate:
                if (bulletStatus != null)
                {
                    bulletStatus.criticalChance = newStats.playerCritrate;
                    Debug.Log($"Player Critrate adjusted to {newStats.playerCritrate}");
                }
                else
                {
                    Debug.LogWarning("BulletStatus script is not assigned!");
                }
                break;

            case AdjustOption.AdjustEnemiesCritrate:
                if (bulletStatus != null)
                {
                    bulletStatus.criticalChance = newStats.enemieCritrate;
                    Debug.Log($"Enemies Critrate adjusted to {newStats.enemieCritrate}");
                }
                else
                {
                    Debug.LogWarning("BulletStatus script is not assigned!");
                }
                break;

            case AdjustOption.AdjustEnemiesInterval:
                if (monsterAI != null)
                {
                    monsterAI.timeDurationIddleAfterAttack = newStats.enemiesInterval;
                    Debug.Log($"Enemies Interval adjusted to {newStats.enemiesInterval}");
                }
                else
                {
                    Debug.LogWarning("MonsterAI script is not assigned!");
                }
                break;
        }
    }
    public static List<NewStatsImplementer> allInstances = new List<NewStatsImplementer>();

    private void Awake()
    {
        if (!allInstances.Contains(this))
            allInstances.Add(this);
    }

    private void OnDestroy()
    {
        allInstances.Remove(this);
    }
}
