using UnityEngine;

public class spawnManager : MonoBehaviour
{
  
  public GameObject enemyPrefab;
  private float spawnRange=9;
    void Start()
    { 
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }
    void Update()
    {
        
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnpPosX=Random.Range(-spawnRange,spawnRange);
        float spawnpPosZ=Random.Range(-spawnRange,spawnRange);
        Vector3 randomPos = new Vector3(spawnpPosX,0,spawnpPosZ);
        return randomPos;
    }
}
