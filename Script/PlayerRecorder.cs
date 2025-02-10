using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerRecorder : MonoBehaviour
{
    // public GameObject player;
    [SerializeField] private float lastWaveDuration;
    [HideInInspector] public AjisakaDataStage dataStage;

    private bool isCounting = false;
    [SerializeField] int lastWaveHpLost;
    [SerializeField] int thisWaveHpLost;
    private float startTime;
    private float endTime;
    DifficultyAdjuster difficultyAdjuster;
    public void StartWave()
    {

        if (isCounting == false)
        {
            Debug.Log("Wave Dimulai");
            isCounting = true;
            startTime = Time.time;  // Catat waktu saat wave dimulai
            // Status playerStatus = player.GetComponent<Status>();
            // initialHp = playerStatus.health;  // Menyimpan HP awal
        }

        return;
    }

    public void EndWave()
    {
        // 
        if (isCounting == true)
        {
            Debug.Log("Wave Berakhir");
            endTime = Time.time;  // Catat waktu saat wave selesai
            isCounting = false;
            // Debug.Log("Wave berganti");
            CalculateWaveDuration();  // Hitung durasi wave
            startTime = Time.time;
            Debug.Log("HP yang hilang selama wave: " + thisWaveHpLost);

            lastWaveHpLost = thisWaveHpLost;
            thisWaveHpLost = 0;
            difficultyAdjuster = FindObjectOfType<DifficultyAdjuster>();
            difficultyAdjuster.Run();
        }
        return;
    }

    void CalculateWaveDuration()
    {
        lastWaveDuration = endTime - startTime;  // Durasi wave dalam detik
        Debug.Log("Durasi wave: " + lastWaveDuration + " detik");
        return;
    }

    public void CalculateHpLost(int damgeReceived)
    {

        // Ambil HP akhir setelah wave selesai
        thisWaveHpLost = (thisWaveHpLost + damgeReceived);
        return;
    }
    public void setDataStage(AjisakaDataStage EnemyList)
    {
        dataStage = EnemyList;
    }

    public float ClearTime
    {
        get { return lastWaveDuration; }
    }

    // Getter untuk hpLost
    public float HpLost
    {
        get { return lastWaveHpLost; }
    }
    public AjisakaDataStage DataStage
    {
        get { return dataStage; }
    }
}

