using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyIdentity;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float spawnTime;
    private Vector2 spawnPosition;
    [SerializeField]
    private float minX, maxX, minY, maxY;
    private float thresholdDistance = 1f;
    private Vector2 playerIdentity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0 )
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        RandomLocationGeneration();
        Instantiate(enemyIdentity, spawnPosition, Quaternion.identity);
        SetTimeUntilSpawn();
    }

    void SetTimeUntilSpawn()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void RandomLocationGeneration()
    {
        playerIdentity = GameObject.FindGameObjectWithTag("Player").transform.position;
        float distance = 0;
        while (spawnPosition == null || distance <= thresholdDistance)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            spawnPosition = new Vector2(randomX, randomY);
            distance = Vector2.Distance(playerIdentity, spawnPosition);
        }
    }
}
