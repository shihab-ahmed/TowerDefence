using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyWaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    private int waveNumber = 5;
    public Transform spawnPoint;
    public TextMeshProUGUI waveCountDownText;
    private void Update()
    {
        //if(countdown <=0)
        //{
        //    StartCoroutine(SpawnWave());
        //    countdown = timeBetweenWaves;
        //}
        //countdown -= Time.deltaTime;
        //waveCountDownText.text = ((int)countdown).ToString();
    }
    public void SpawnAWave()
    {
        StartCoroutine(SpawnWave());
    }
    IEnumerator SpawnWave()
    {
        Debug.Log("wave incoming");
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation);
    }
}
