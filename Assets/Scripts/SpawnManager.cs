using System.Collections;
using UnityEngine;

// Class ini bertanggung jawab penuh untuk memunculkan Pipa
public class SpawnManager : MonoBehaviour
{
    // ENCAPSULATION: Variabel Prefab dan timing dibuat private/serialized
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate = 2f; // Kecepatan muncul Pipa (detik)
    [SerializeField] private float heightRange = 3f; // Batas variasi ketinggian Pipa

    void Start()
    {
        StartCoroutine(SpawnPipesRoutine());
    }

    // Coroutine untuk mengatur timing spawning
    IEnumerator SpawnPipesRoutine()
    {
        // Looping tanpa batas selama game berjalan
        while (true)
        {
            SpawnPipe();
            // Jeda selama waktu 'spawnRate' sebelum loop dilanjutkan
            yield return new WaitForSeconds(spawnRate);
        }
    }

    // LOGIKA UTAMA SPAWNING: Fungsi untuk membuat satu instance Pipa
    void SpawnPipe()
    {
        if (pipePrefab == null)
        {
            Debug.LogError("Pipe Prefab not assigned in SpawnManager!");
            return;
        }

        // Tentukan posisi Y acak dalam batas 'heightRange'
        float randomY = Random.Range(-heightRange, heightRange);

        // Tentukan posisi spawn (X selalu di kanan, Y acak)
        Vector3 spawnPosition = new Vector3(10f, randomY, 0f);

        // INSTANTIATE: Membuat objek PipePrefab di posisi yang telah ditentukan
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}