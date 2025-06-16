using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject m_Object;
    [SerializeField] private float m_SpawnTime = 2f;
    [SerializeField] private float verticalRange = 3f;
    private float timer;

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > m_SpawnTime)
        {
            SpawnObstacle();
            timer = 0f;
        }

    }

    private void SpawnObstacle()
    {
        float offsetY = UnityEngine.Random.Range(-verticalRange, verticalRange);
        Vector3 spawnPosition = transform.position + new Vector3(0, offsetY, 0);
        Instantiate(m_Object, spawnPosition, Quaternion.identity);


    }
}
