using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] prefabs; 
    public int objectCount = 10;
    public float spawnRange = 5f;

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < objectCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnRange, spawnRange),
                0.5f,
                Random.Range(-spawnRange, spawnRange)
            );

            int prefabIndex = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[prefabIndex], randomPosition, Quaternion.identity);
        }
    }
}
