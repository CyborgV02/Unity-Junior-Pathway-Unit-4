using UnityEngine;

public class spawnManager : MonoBehaviour
{
  public GameObject enemyPrefab;
  private float spawnRange=9;
  public int waveCount=1;
  public GameObject powerUpprefab;
  public float enemyCount;
    void Start()
    { 
     Instantiate(powerUpprefab,GenerateSpawnPosition(),powerUpprefab.transform.rotation);
     spawnEnemyWave(1);
    }
    void Update()
    {
     enemyCount=FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;
     if (enemyCount == 0)
        {
            Instantiate(powerUpprefab,GenerateSpawnPosition(),powerUpprefab.transform.rotation);
            waveCount++;
            spawnEnemyWave(waveCount);
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnpPosX=Random.Range(-spawnRange,spawnRange);
        float spawnpPosZ=Random.Range(-spawnRange,spawnRange);
        Vector3 randomPos = new Vector3(spawnpPosX,0,spawnpPosZ);
        return randomPos;
    }

    void spawnEnemyWave(int enemiestospawn)
    {
        for (int i = 0; i < enemiestospawn ; i++)
        {
             Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
