using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class ExportEnemiesToCSV : MonoBehaviour
{
    [Header("Drag and drop your DataStage ScriptableObject here")]
    public AjisakaDataStage dataStage;

    [Header("Drag and drop your CSV file here")]
    public TextAsset csvFile;

    [Header("Balancing Parameters")]
    public float powerScale = 1.0f;
    public float maxPlayerDPS = 100.0f;
    public float enemiesAtkInterval = 1.0f;

    public void ExportToCSV()
    {
        if (dataStage == null)
        {
            Debug.LogError("DataStage is not assigned!");
            return;
        }

        if (csvFile == null)
        {
            Debug.LogError("CSV file is not assigned!");
            return;
        }

        string filePath = Application.dataPath + "/" + csvFile.name + ".csv";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write CSV headers
            writer.WriteLine("StageName,AreaName,WaveName,EnemyPrefabName,EnemyPower,MinClearTime,MaxClearTime,MaxHpLost");

            // Loop through all the areas and waves to extract enemy data
            foreach (AjisakaDataArea area in dataStage.listDataArea)
            {
                foreach (AjisakaDataWave wave in area.listDataWave)
                {
                    float totalEnemyPower = 0; // Total wave power
                    int enemyCount = 0; // Total enemy count

                    // Collect enemy data
                    foreach (GameObject enemyPrefab in wave.listPrefabEnemies)
                    {
                        string enemyName = "Unknown";
                        float enemyPower = 0;

                        var status = enemyPrefab.GetComponent<Status>();
                        if (status != null)
                        {
                            enemyName = status.characterName;
                        }

                        var powerCounter = enemyPrefab.GetComponent<EnemyPowerCounter>();
                        if (powerCounter != null)
                        {
                            enemyPower = powerCounter.enemyPower;
                            totalEnemyPower += enemyPower;
                        }
                        else
                        {
                            Debug.LogWarning($"EnemyPrefab {enemyPrefab.name} does not have an EnemyPowerCounter component.");
                        }

                        enemyCount++;
                        writer.WriteLine($"{dataStage.DataStageName},{area.dataAreaName},{wave.dataWaveName},{enemyPrefab.name},{enemyPower},,,"); // Write enemy data
                    }

                    // Calculate Clear Times and HP Lost
                    float minClearTime = ((totalEnemyPower * powerScale) / maxPlayerDPS) + enemyCount;
                    float maxClearTime = minClearTime * 2;

                    float enemiesDPS = 20 / (enemiesAtkInterval + 1);
                    float maxHpLost = ((maxClearTime - enemyCount) + ((enemyCount * (enemyCount - 1)) / 2)) * enemiesDPS;

                    // Write total power row with calculated values
                    writer.WriteLine($",,,TotalEnemyPower,{totalEnemyPower},{minClearTime},{maxClearTime},{maxHpLost}");
                }
            }
        }

        Debug.Log($"Enemies data successfully exported to: {filePath}");
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(ExportEnemiesToCSV))]
public class ExportEnemiesToCSVEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ExportEnemiesToCSV script = (ExportEnemiesToCSV)target;
        if (GUILayout.Button("Export To CSV"))
        {
            script.ExportToCSV();
        }
    }
}
#endif
