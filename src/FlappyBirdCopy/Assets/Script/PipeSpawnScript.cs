using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public float maxTime = 1;
    public float timer = 0;
    public GameObject pipe;
    public float yukseklik; // Bu, boruların ne kadar yüksek veya alçak olabileceğini belirler

    public float minY = -1.0f; // Minimum Y pozisyonu
    public float maxY = 1.0f;  // Maksimum Y pozisyonu

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        GameObject newpipe = Instantiate(pipe);
        // Borunun Y pozisyonunu sınırlı bir aralıkta belirle
        float yPosition = Random.Range(minY, maxY);
        newpipe.transform.position = transform.position + new Vector3(0, yPosition, 0);
        Destroy(newpipe, 15);
    }
}
