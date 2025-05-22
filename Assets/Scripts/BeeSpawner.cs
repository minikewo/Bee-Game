using UnityEngine;
using UnityEngine.UIElements;

public class BeeSpawner : MonoBehaviour
{
    public GameObject[] objectToSpawn;
    public float spawnInterval = 4f; 
    public Vector2 spawnRangeX = new Vector2(-5f, 5f);
    public float spawnRadius = 1.5f; 
    
    private float _timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x += Random.Range(spawnRangeX.x, spawnRangeX.y);
    }
}
