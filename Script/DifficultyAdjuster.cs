using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System.Reflection;
using JetBrains.Annotations;

[System.Serializable]
public class VariableUpdate
{
    public string variableName; // Nama variabel di script prefab yang ingin diubah
    public string newValueReference; // Nama variabel dari script ini yang akan digunakan sebagai nilai baru
}

[System.Serializable]
public class FolderModification
{
    public DefaultAsset prefabFolder; // Folder tempat prefab berada
    public List<ScriptModification> scriptModifications; // Daftar script dan variabel yang ingin diubah untuk folder ini
}

[System.Serializable]
public class ScriptModification
{
    public string scriptName; // Nama script yang ingin diubah
    public List<VariableUpdate> variableUpdates; // Daftar variabel yang akan diubah
}

public class DifficultyAdjuster : MonoBehaviour
{

    [Header("Folder Modification Settings")]
    [SerializeField] private List<FolderModification> folderModifications; // Daftar folder dan script yang akan dimodifikasi

    // Private variables

    // Fungsi untuk mendapatkan daftar variabel dan nilai baru
    public Dictionary<string, object> GetVariableUpdates()
    {
        return new Dictionary<string, object>
        {
            { "health", 150 },
            { "damage", 50 },
            { "speed", 10.5f }
        };
    }

    public AjisakaDataStage dataStage;
    private float wavePower = 0.3f;
    [SerializeField] private float powerScale = 800;
    [SerializeField] private float maxPlayerDPS = 68;
    [SerializeField] private int enemyCount;
    [SerializeField] private float intervalDefault = 2.5f;
    [SerializeField] private int powerToClearScale = 6;
    [SerializeField] private int CleartimeStandartRange = 4;
    [SerializeField] private int lowHpTreshold = 100;
    private float clearTime = 130f;         // Waktu yang dibutuhkan pemain untuk menyelesaikan wave
    private float minClearTime = 100f;     // Waktu tercepat untuk menyelesaikan wave
    private float maxClearTime = 200f;
    [SerializeField] private float standardClearTime;  // Waktu terlambat untuk menyelesaikan wave
    private float hpNow = 250f;            // HP sekarang pemain
    private float hpLost = 30f;            // HP yang hilang pada wave sebelumnya
    private float minHpLost = 0f;          // HP hilang minimum untuk maksimal enemyCritRate
    private float maxHpLost = 80f;         // HP hilang maksimum untuk minimal enemyCritRate
    [SerializeField] private float standardHpLost;
    private float enemiesDPS;
    private float enemyCritRatePrev = 10f; // Enemy crit rate dari wave sebelumnya
    private float enemiesIntervalPrev = 3f; // Interval musuh dari wave sebelumnya
    [SerializeField] private int currentWave = 1;

    // Variabel hasil kalkulasi
    [SerializeField] private int playerCritRate;
    [SerializeField] private int enemyCritRate;
    [SerializeField] private float enemiesInterval;
    private int playerCritRateDefault = 35;
    private int enemyCritRateDefault = 15;
    private float enemiesIntervalDefault = 2.5f;
    private float adjustableWavePower;
    private float weightPlayerCritToPower = 0.15f;
    private float weightEnemyCritToPower = 0.05f;
    private float weightEnemyIntervalToPower = 0.1f;
    private float playerCritMax = 60f;
    private float playerCritMin = 10f;
    private float enemyCritMax = 30f;
    private float enemyCritMin = 0f;
    private float enemyIntervalMax = 5f;
    private float enemyIntervalMin = 0f;
    PlayerRecorder playerRecorder;



    public void Start()
    {
        ImplementNewStats(playerCritRateDefault, enemyCritRateDefault, enemiesIntervalDefault);
    }

    public void CalculateAll()
    {
        playerRecorder = FindObjectOfType<PlayerRecorder>();
        clearTime = playerRecorder.ClearTime;
        hpLost = playerRecorder.HpLost;

        DecideStandartCleartime();
        DecideStandartHpLost();
        // Hitung nilai baru
        playerCritRate = CalculatePlayerCrit();
        enemyCritRate = CalculateEnemyCritRate();
        enemiesInterval = CalculateEnemiesInterval();

        // Tampilkan hasil di konsol (bisa diganti dengan UI)
        Debug.Log($"Player Crit Rate: {playerCritRate}");
        Debug.Log($"Enemy Crit Rate: {enemyCritRate}");
        Debug.Log($"Enemies Interval: {enemiesInterval}");
        ImplementNewStats(playerCritRate, enemyCritRate, enemiesInterval);
        ApplyToAll();
    }
    public void ApplyToAll()
    {
        NewStatsImplementer[] allImplementers = FindObjectsOfType<NewStatsImplementer>();

        foreach (var instance in NewStatsImplementer.allInstances)
        {
            instance.ApplyAdjustment();
        }

        Debug.Log($"Applied adjustments to {allImplementers.Length} objects.");
    }

    private int CalculatePlayerCrit()
    {
        float thetaPlayerCrit = playerCritMin + ((clearTime - minClearTime) / (maxClearTime - minClearTime) * (playerCritMax - playerCritMin));
        Mathf.Clamp(thetaPlayerCrit, playerCritMin, playerCritMax);
        int intNumber = (int)thetaPlayerCrit;
        return intNumber;
    }

    private int CalculateEnemyCritRate()
    {
        float enemyCritRate = (maxHpLost - hpLost) / maxHpLost * (enemyCritMax-enemyCritMin);
        enemyCritRate = Mathf.Clamp(enemyCritRate, enemyCritMin, enemyCritMax);

        if (hpNow <= lowHpTreshold)
        {
            enemyCritRate = enemyCritMin;
        }

        if (hpLost <= standardHpLost && clearTime >= standardClearTime)
        {
            enemyCritRate = enemyCritRatePrev;
        }

        if (clearTime <= standardClearTime && hpLost >= standardHpLost)
        {
            enemyCritRate = ((maxClearTime - clearTime) / (maxClearTime - minClearTime) * (enemyCritMax-enemyCritMin));
            enemyCritRate = Mathf.Clamp(enemyCritRate, enemyCritMin, enemyCritMax);
        }

        enemyCritRatePrev = enemyCritRate;


        int intNumber = (int)enemyCritRate;
        return intNumber;
    }

    private float CalculateEnemiesInterval()
    {
        float enemiesInterval = ((clearTime - minClearTime) / (maxClearTime - minClearTime)) * enemyIntervalMax;
        enemiesInterval = Mathf.Clamp(enemiesInterval, enemyIntervalMin, enemyIntervalMax);

        if (clearTime <= standardClearTime && hpLost >= standardHpLost)
        {
            enemiesInterval = enemiesIntervalPrev;
        }

        enemiesIntervalPrev = enemiesInterval;
        return enemiesInterval;
    }


    // Function to calculate clear time
    private void DecideStandartCleartime()
    {
        // Clear Time Decider variabl
        standardClearTime = (enemyCount / 2) + (wavePower * powerToClearScale);
        minClearTime = standardClearTime - CleartimeStandartRange;
        maxClearTime = standardClearTime + CleartimeStandartRange;

        Debug.Log($"Clear Time - Min: {minClearTime}, Max: {maxClearTime}, Standard: {standardClearTime}");
    }

    // Function to calculate HP lost
    private void DecideStandartHpLost()
    {
        // HP Lost Decider variables

        minHpLost = 0;
        enemiesDPS = 20 / (enemiesInterval + 1);
        maxClearTime = ((wavePower * powerScale) / maxPlayerDPS) + enemyCount * 2; // Pre-calculated maxClearTime
        maxHpLost = ((maxClearTime - enemyCount) + ((enemyCount * (enemyCount - 1)) / 2)) * enemiesDPS;
        standardHpLost = maxHpLost / 2;

        Debug.Log($"HP Lost - Min: {minHpLost}, Max: {maxHpLost}, Standard: {standardHpLost}");
    }

    private void EnemiesChecker()
    {
        if (dataStage != null)
        {
            // Debug.Log($"Data Stage Name: {dataStage.DataStageName}");
            foreach (var area in dataStage.listDataArea)
            {
                // Debug.Log($"Area Name: {area.dataAreaName}, Time Next Wave: {area.timeNextWave}");
                foreach (var wave in area.listDataWave)
                {
                    // Debug.Log($"Wave Name: {wave.dataWaveName}");
                    foreach (var enemyPrefab in wave.listPrefabEnemies)
                    {
                        // Mendapatkan nama dari script "Status"
                        string enemyName = "Unknown";
                        float enemyPower = 0;

                        var status = enemyPrefab.GetComponent<Status>();
                        if (status != null)
                        {
                            enemyName = status.characterName; // Mengambil nama dari script Status
                        }

                        var powerCounter = enemyPrefab.GetComponent<EnemyPowerCounter>();
                        if (powerCounter != null)
                        {
                            enemyPower = powerCounter.enemyPower; // Mengambil power dari script EnemyPowerCounter
                        }
                        // Debug.Log($"Enemy Name: {enemyName}, Power: {enemyPower}");
                    }
                }
            }
            UpdateWavePower();
            currentWave++;
        }
        else
        {
            // Debug.LogError("DataStage ScriptableObject is not assigned!");
        }
    }
    private void UpdateWavePower()
    {
        if (dataStage == null)
        {
            Debug.LogError("DataStage ScriptableObject is not assigned!");
            return;
        }

        int waveCounter = 0; // Counter untuk menghitung wave secara berurutan
        foreach (var area in dataStage.listDataArea)
        {
            foreach (var wave in area.listDataWave)
            {
                waveCounter++;
                if (waveCounter == currentWave)
                {
                    // Jika wave yang dimaksud ditemukan, hitung total enemyPower
                    float totalEnemyPower = 0f;


                    enemyCount = 0;

                    foreach (var enemyPrefab in wave.listPrefabEnemies)
                    {
                        var powerCounter = enemyPrefab.GetComponent<EnemyPowerCounter>();
                        if (powerCounter != null)
                        {
                            totalEnemyPower += powerCounter.enemyPower;
                        }

                        enemyCount++;
                    }

                    Debug.Log($"Enemy Count: {enemyCount}");
                    // Update wavePower
                    wavePower = totalEnemyPower + AdjustableToPower();
                    Debug.Log($"Wave Power for Wave {currentWave}: {wavePower}");
                    return; // Keluar setelah menemukan dan mengupdate wavePower
                }
            }
        }

        // Jika currentWave tidak ditemukan
        Debug.LogError($"Wave {currentWave} not found in the provided DataStage!");
    }

    private float AdjustableToPower()
    {
        float powerFromPCritrate = ((playerCritMax - playerCritRate) / (playerCritMax - playerCritMin) * weightPlayerCritToPower);
        float powerFromECritrate = ((enemyCritRate - enemyCritMin) / (enemyCritMax - enemyCritMin) * weightEnemyCritToPower);
        float powerFromEInterval = ((enemyIntervalMax - enemiesInterval) / (enemyIntervalMax - enemyIntervalMin) * weightEnemyIntervalToPower);
        Debug.Log("hasil hitungan PCrit:" + powerFromPCritrate + "ECrit:" + powerFromECritrate + "PIntvl:" + powerFromEInterval);
        return powerFromPCritrate + powerFromECritrate + powerFromEInterval;
    }

    // Example of initializing variables and running calculations
    public void Run()
    {
        enemiesInterval = enemiesIntervalDefault;
        EnemiesChecker();
        CalculateAll();
    }
    public AdjustableStats enemyStats;
    public void ImplementNewStats(int newPlayerCritrate, int newEnemiesCritrate, float newEnemiesInterval)
    {


        if (enemyStats != null)
        {
            enemyStats.playerCritrate = newPlayerCritrate;
            enemyStats.enemieCritrate = newEnemiesCritrate;
            enemyStats.enemiesInterval = newEnemiesInterval;
        }
    }
}
